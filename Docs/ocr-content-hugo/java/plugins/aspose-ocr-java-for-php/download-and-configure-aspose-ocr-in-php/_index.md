---
title: Download and Configure Aspose.OCR in PHP
type: docs
weight: 10
url: /java/download-and-configure-aspose-ocr-in-php/
---

## **Download Required Libraries**
Download required libraries mentioned below. These are the required for executing Aspose.OCR Java for PHP examples.

- **Aspose:** [Aspose.OCR for Java Component](http://www.aspose.com/community/files/72/java-components/aspose.OCR-for-java/default.aspx)
- [PHP/Java Bridge](http://citylan.dl.sourceforge.net/project/php-java-bridge/Binary%20package/php-java-bridge_6.2.1/php-java-bridge_6.2.1_documentation.zip)
## **Download Examples from Social Coding Sites**
Following releases of running examples are available to download on below mentioned social coding sites:

-----
### **GitHub**
- **Aspose.OCR Java for PHP Examples** 
  - [Aspose.OCR Java for PHP](https://github.com/aspose-ocr/Aspose.OCR-for-Java/tree/master/Plugins/Aspose_OCR_Java_for_PHP)
### **CodePlex**
- **Aspose.OCR Java for PHP Examples** 
  - [Aspose.OCR Java for PHP](https://asposeocrjavaphp.codeplex.com/)
## **How to configure the source code on Linux Platform**
Please follow these simple steps in order to open and extend the source code while using:
## **1. Install Tomcat Server**
To install tomcat server, issue following command on the linux console. This will successfully install tomcat server. 

{{< highlight actionscript3 >}}

 sudo apt-get install tomcat8

{{< /highlight >}}
## **2. Download and Configure PHP/JavaBridge**
In order to download the PHP/JavaBridge binaries, issue following command on the linux console. 

{{< highlight actionscript3 >}}

  wget http://citylan.dl.sourceforge.net/project/php-java-bridge/Binary%20package/php-java-bridge_6.2.1/php-java-bridge_6.2.1_documentation.zip 

{{< /highlight >}}


Unzip the PHP/JavaBridge binaries by issuing the following command on linux console. 

{{< highlight actionscript3 >}}

  unzip -d php-java-bridge_6.2.1_documentation.zip 

{{< /highlight >}}


This will extract **JavaBridge.war** file. Copy it to tomcat88 **webapps** folder by issuing the following command on Linux console. 

{{< highlight actionscript3 >}}

  sudo cp JavaBridge.war /var/lib/tomcat8/webapps/JavaBridge.war 

{{< /highlight >}}


By copying, tomcat8 will automatically create a new folder "**JavaBridge**" in **webapps**. Once the folder is created, make sure your tomcat8 is running and then check <http://localhost:8080/JavaBridge> in browser, it should open a default page of JavaBridge. 

If any error message appears then install  **FastCGI** by issuing the following command on Linux console.

{{< highlight actionscript3 >}}

  sudo apt-get install php55-cgi 

{{< /highlight >}}

After installing php5.5 cgi, restart tomcat8 server and check <http://localhost:8080/JavaBridge> again in the browser.

If **JAVA_HOME** error is displayed, then open /etc/default/tomcat8 file and uncomment the line that sets the JAVA_HOME. Check <http://localhost:8080/JavaBridge> in browser again, it should come with PHP/JavaBridge Examples page. 
## **3. Configure Aspose.OCR Java for PHP Examples**
Clone, PHP examples by issuing the following commands inside webapps/JavaBridge folder.  

{{< highlight actionscript3 >}}

 $ git init&nbsp;

$ git clone [https://github.com/asposeslides/Aspose.OCR-for-Java/tree/master/Plugins/Aspose.OCR-for-Java_for_PHP] 

{{< /highlight >}}

## **How to configure the source code on Windows Platform**
Please follow below simple steps to configure PHP/Java Bridge on Windows Platform

\1. Install PHP5 and configure as you normally do
\2. Install JRE 6 (Java Runtime Environment) if you don’t already have it. You can check this in C:\Program Files etc. You can download it here . I am using JRE 6 as It is compatible with PHP Java Bridge (PJB).

\3. Install Apache Tomcat 8.0. You can download it here

4.Download [JavaBridge.war](http://sourceforge.net/projects/php-java-bridge/files/Binary%20package/php-java-bridge_6.2.1/JavaBridgeTemplate621.war/download). Copy this file to tomcat webapps directory.
(ex: C:\Program Files\Apache Software Foundation\Tomcat 8.0\webapps )

\5. Restart tomcat apache service.

6.Go to <http://localhost:8080/JavaBridge/test.php> to check if php works. You can find other examples in there

7.Copy your [Aspose.OCR Java](http://www.aspose.com/community/files/72/java-components/aspose.ocr-for-java/default.aspx) jar file to C:\Program Files\Apache Software Foundation\Tomcat 8.0\webapps\JavaBridge\WEB-INF\lib

\8. Clone [Aspose.OCR Java for PHP](https://github.com/aspose-ocr/Aspose.OCR-for-Java/tree/master/Plugins/Aspose_OCR_Java_for_PHP) examples inside C:\Program Files\Apache Software Foundation\Tomcat 8.0\webapps\ folder.

\8. Copy folder C:\Program Files\Apache Software Foundation\Tomcat 8.0\webapps\JavaBridge\java to your Aspose.OCR Java for PHP examples folder.

\10. Restart apache tomcat service and start using examples. 
