using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using System.IO;
using Practica6;
using Practica6.Droid;


[assembly: Dependency(typeof(ISQD))]
namespace Practica6.Droid
{
    public class ISQD : SQLI
    {
        public string GetLocalFilePath(string Filename)
        {
            string path = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            return Path.Combine(path, Filename);
        }
    }
}