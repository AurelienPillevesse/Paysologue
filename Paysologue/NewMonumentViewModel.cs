using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Métier;
using System.Windows;

namespace Paysologue
{
    public class NewMonumentViewModel
    {
        public Monument NewMonu
        {
            get;
            set;
        }

        public NewMonumentViewModel(Monument m)
        {
            NewMonu = m;
        }

        public void Parcourir()
        {
            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();
            string s = "C:\\Users\\" + Environment.UserName + "\\Desktop";
            dlg.InitialDirectory = s;
            dlg.FileName = "Images";
            dlg.DefaultExt = ".jpg | .png | .gif";
            dlg.Filter = "All images files (.jpg, .png, .gif)|*.jpg;*.png;*.gif|JPG files (.jpg)|*.jpg|PNG files (.png)|*.png|GIF files (.gif)|*.gif";

            bool? result = dlg.ShowDialog();

            if (result == true)
            {
                NewMonu.Image = dlg.FileName;
            }
        }
    }
}
