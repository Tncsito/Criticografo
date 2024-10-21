using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Criticografo_DA_EESA
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void R_Clicked(object sender, EventArgs e)
        {
            string _Nombre = Nombre.Text;            
            string a = _Nombre + " es";
            if (M.IsChecked)
            {
                a = a + " Mujer";
                if (Alto.IsChecked)
                {
                    a = a + ", Alta";
                }
                if (Listo.IsChecked)
                {
                    a = a + ", lista";
                }
                if (Raro.IsChecked)
                {
                    a = a + ", Rara";
                }
                if (Feo.IsChecked)
                {
                    a = a + ", Fea";
                }
                if (Extravagante.IsChecked)
                {
                    a = a + ", Extravagante";
                }
                if (Grande.IsChecked)
                {
                    a = a + ", Grande";
                }
            }
            else if (H.IsChecked)
            {
                a = a + " Hombre";

                if (Alto.IsChecked)
                {
                    a = a + ", Alto";
                }
                if (Listo.IsChecked)
                {
                    a = a + ", listo";
                }
                if (Raro.IsChecked)
                {
                    a = a + ", Raro";
                }
                if (Feo.IsChecked)
                {
                    a = a + ", Feo";
                }
                if (Extravagante.IsChecked)
                {
                    a = a + ", Extravagante";
                }
                if (Grande.IsChecked)
                {
                    a = a + ", Grande";
                }
            }
            DisplayAlert("Resultado",a+".", "Cerrar");

        }
    }
}
