using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Xamarin.Forms;
using SQLite;
using Foundation;
using UIKit;
using Practica6;
using Practica6.iOS;
using Prueba.iOS;

[assembly: Dependency(typeof(SQLIO))]

namespace Prueba.iOS
{
    class SQLIO : SQLI
    {
        public string GetLocalFilePath(string filename)
        {
            string docFolder = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            string libFolder = Path.Combine(docFolder, "..", "Library", "Databases");

            if (!Directory.Exists(libFolder))
            {
                Directory.CreateDirectory(libFolder);
            }
            return Path.Combine(libFolder, filename);
        }
    }
}
