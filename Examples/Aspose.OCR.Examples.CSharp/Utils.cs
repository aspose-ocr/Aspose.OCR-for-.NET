﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Aspose.OCR.Examples
{
    class Utils
    {
        public static string GetDataDir(Type t)
        {
            string c = t.FullName;
            c = c.Replace("Aspose.OCR.Examples.", "");
            c = c.Replace('.', Path.DirectorySeparatorChar);
            string p = Path.GetFullPath(Path.Combine(Directory.GetCurrentDirectory(), "..", "..", "..", "Data", c));
            p += Path.DirectorySeparatorChar;
            Console.WriteLine("Using Data Dir {0}", p);
            return p;
        }
    }
}
