using Métier;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paysologue
{
    public class NewPaysViewModel
    {
        public Pays NewPays
        {
            get;
            set;
        }

        public NewPaysViewModel(Pays p)
        {
            NewPays = p;
        }
        
        public void Parcourir(string name)
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
                if (name == "ParcourirCarte")
                    NewPays.Image = dlg.FileName;
                else
                    NewPays.ImageDrap = dlg.FileName;
            }
        }
    }
}
