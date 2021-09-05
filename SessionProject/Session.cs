using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace SessionProject
{
    class FileManager
    {
        String pathDirectory = "";
        public FileManager()
        {

            DirectoryInfo directoryInfo = System.IO.Directory.CreateDirectory(".\\store");
            pathDirectory = directoryInfo.FullName;

        }

      