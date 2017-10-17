using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;
using Xamarin.Forms;
using SQLite;
using Practica6;
using Practica6.UWP;

[assembly: Dependency(typeof(SQLW))]
namespace Practica6.UWP
{
    public class SQLW : SQLI
    {
        public string GetLocalFilePath(string filename)
        {
            return Path.Combine(ApplicationData.Current.LocalFolder.Path, filename);
        }

    }
}
