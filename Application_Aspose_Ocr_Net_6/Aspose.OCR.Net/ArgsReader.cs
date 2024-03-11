using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Aspose.OCR.Net
{
    internal class ArgsReader
    {
        private static List<string>? m_args = null;
        private static bool m_noMoreOptions;
        public static InputParams Run(IReadOnlyList<string> args)
        {
            try
            {
                m_args = (args ?? throw new ArgumentNullException(nameof(args))).ToList();

                var language = ReadLanguageOption();
                var SourcePath = ReadSourceOption();
                var OutputPath = ReadOutputOption();
                if (!IsOutputTypeValid(OutputPath))
                {
                    OutputPath = null;
                }

                var LicensePath = ReadLicenseOption();

                if (SourcePath == null)
                    throw new ArgsReaderException("Missing input path.");

                var input = File.Exists(SourcePath)
                    ? SourcePath
                    : throw new ArgsReaderException("Missing input file.");

                return new InputParams
                {
                    language = language,
                    inputPath = SourcePath,
                    outputPath = OutputPath,
                    fileType = ParseInputType(SourcePath),
                    licensePath = LicensePath
                };
            }
            catch (Exception exception)
            {
                if (exception is ArgsReaderException)
                {
                    Console.Error.WriteLine(exception.Message);
                    Console.Error.WriteLine();
                    return null;
                }
                else if (exception is ApplicationException || exception is IOException)
                {
                    Console.Error.WriteLine(exception.Message);
                    return null;
                }
                else
                {
                    Console.Error.WriteLine(exception.ToString());
                    return null;
                }
            }
        }

        public static string? ReadArgument()
        {
            if (m_args.Count == 0)
                return null;

            var value = m_args[0];

            if (NoOptionsAfterDoubleDash && value == "--")
            {
                m_args.RemoveAt(0);
                m_noMoreOptions = true;
                return ReadArgument();
            }

            if (!m_noMoreOptions && IsOption(value))
                throw new ArgsReaderException($"Unexpected option '{value}'.");

            m_args.RemoveAt(0);
            return value;
        }

        public static Language ReadLanguageOption()
        {
            var value = ReadOption("language");
            if (value == null)
            {
                return Language.None;
            }

            try
            {
                return (Language)Enum.Parse(typeof(Language), char.ToUpper(value[0]) + value.Substring(1));
            }
            catch
            {
                throw new ArgsReaderException($"Invalid language '{value}'. (Read documentation.)");
            }
        }

        public static string? ReadSourceOption() => ReadOption("source");
        public static string? ReadOutputOption() => ReadOption("output");
        public static string? ReadLicenseOption() => ReadOption("license");

        public static string? ReadOption(string name)
        {
            if (name == null)
                throw new ArgumentNullException(nameof(name));
            if (name.Length == 0)
                throw new ArgumentException("Option name must not be empty.", nameof(name));

            var names = name.Split('|');
            if (names.Length > 1)
                return names.Select(ReadOption).FirstOrDefault(x => x != null);

            var index = FindOptionArgumentIndex(name);
            if (index == -1)
                return null;

            var value = index + 1 < m_args.Count ? m_args[index + 1] : null;
            if (value == null || IsOption(value))
                throw new ArgsReaderException($"Missing value after '{RenderOption(name)}'.");

            m_args.RemoveAt(index);
            m_args.RemoveAt(index);
            return value;
        }

        public static bool ReadFlag(string name)
        {
            if (name == null)
                throw new ArgumentNullException(nameof(name));
            if (name.Length == 0)
                throw new ArgumentException("Flag name must not be empty.", nameof(name));

            var names = name.Split('|');
            if (names.Length > 1)
                return names.Any(ReadFlag);

            var index = FindOptionArgumentIndex(name);
            if (index == -1)
                return false;

            m_args.RemoveAt(index);
            return true;
        }


        private static int FindOptionArgumentIndex(string optionName)
        {
            for (var index = 0; index < m_args.Count; index++)
            {
                var arg = m_args[index];
                if (NoOptionsAfterDoubleDash && arg == "--")
                    break;
                if (IsOptionArgument(optionName, arg))
                    return index;
            }

            return -1;
        }

        private static bool IsOptionArgument(string optionName, string argument)
        {
            var renderedOption = RenderOption(optionName);
            if (optionName.Length == 1)
            {
                return string.Equals(argument, renderedOption, ShortOptionIgnoreCase ? StringComparison.OrdinalIgnoreCase : StringComparison.Ordinal);
            }
            else
            {
                if (LongOptionIgnoreKebabCase)
                {
                    argument = Regex.Replace(argument, @"\b-\b", "");
                    renderedOption = Regex.Replace(renderedOption, @"\b-\b", "");
                }

                return string.Equals(argument, renderedOption, LongOptionIgnoreCase ? StringComparison.OrdinalIgnoreCase : StringComparison.Ordinal);
            }
        }

        private static InputType ParseInputType(string fileName)
        {
            string fileExtension = Path.GetExtension(fileName);

            return fileExtension.ToLower() switch
            {
                ".png" => InputType.SingleImage,
                ".jpg" => InputType.SingleImage,
                ".jpeg" => InputType.SingleImage,
                ".bmp" => InputType.SingleImage,
                ".ico" => InputType.SingleImage,
                ".zip" => InputType.Zip,
                ".tif" => InputType.TIFF,
                ".tiff" => InputType.TIFF,
                ".pdf" => InputType.PDF,
                ".djvu" => InputType.DJVU,
                null => throw new ArgsReaderException($"Invalid file extension '{fileExtension}'. (Read documentation: supported input types.)"),
                _ => throw new ArgsReaderException($"Invalid file extension '{fileExtension}'. (Read documentation: supported input types.)"),
            };
        }

        private static bool IsOutputTypeValid(string? fileName)
        {
            string fileExtension = Path.GetExtension(fileName);
            return fileExtension == ".txt";
        }

        /// <summary>
		/// True if long options (e.g. <c>--help</c>) should ignore case. (Default false.)
		/// </summary>
		public static bool LongOptionIgnoreCase { get; set; }

        /// <summary>
		/// True if short options (e.g. <c>-h</c>) should ignore case. (Default false.)
		/// </summary>
        public static bool ShortOptionIgnoreCase { get; set; }

        /// <summary>
		/// True if long options (e.g. <c>--dry-run</c>) should ignore "kebab case", i.e. allow <c>--dryrun</c>. (Default false.)
		/// </summary>
        public static bool LongOptionIgnoreKebabCase { get; set; }

        public static bool NoOptionsAfterDoubleDash { get; set; }

        private static bool IsOption(string value) => value.Length >= 2 && value[0] == '-' && value != "--";
        private static string RenderOption(string name) => name.Length == 1 ? $"-{name}" : $"--{name}";
    }
}
