using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace NumerosRomanos1.Vistas
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class V_Principal : ContentPage
    {
        public V_Principal()
        {
            InitializeComponent();
            btnConvertir.Clicked += Btn_convertir_Clicked;
            btnLimpiar.Clicked += Btn_Limpiar_Clicked;
        }

        private void Btn_Limpiar_Clicked(object sender, EventArgs e)
        {
            lblMensaje.Text = "";
            txtNumero.Text = "";
        }

        private void Btn_convertir_Clicked(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(txtNumero.Text);
            string rom = "";
            bool v = true;

            while (true)
            {
                if (n < 4000 && n > 999)
                {
                    switch (n / 1000)
                    {
                        case 1: rom += "M"; break;
                        case 2: rom += "MM"; break;
                        case 3: rom += "MMM"; break;
                    }
                    n -= 1000 * (n / 1000);
                }
                else if (n < 1000 && n > 99)
                {
                    switch (n / 100)
                    {
                        case 1: rom += "C"; break;
                        case 2: rom += "CC"; break;
                        case 3: rom += "CCC"; break;
                        case 4: rom += "CD"; break;
                        case 5: rom += "D"; break;
                        case 6: rom += "DC"; break;
                        case 7: rom += "DCC"; break;
                        case 8: rom += "DCCC"; break;
                        case 9: rom += "CM"; break;
                    }
                    n -= 100 * (n / 100);
                }
                else if (n < 100 && n > 9)
                {
                    switch (n / 10)
                    {
                        case 1: rom += "X"; break;
                        case 2: rom += "XX"; break;
                        case 3: rom += "XXX"; break;
                        case 4: rom += "XL"; break;
                        case 5: rom += "L"; break;
                        case 6: rom += "LX"; break;
                        case 7: rom += "LXX"; break;
                        case 8: rom += "LXXX"; break;
                        case 9: rom += "XC"; break;
                    }
                    n -= 10 * (n / 10);
                }
                else if (n < 10 && n > 0)
                {
                    switch (n)
                    {
                        case 1: rom += "I"; break;
                        case 2: rom += "II"; break;
                        case 3: rom += "III"; break;
                        case 4: rom += "IV"; break;
                        case 5: rom += "V"; break;
                        case 6: rom += "VI"; break;
                        case 7: rom += "VII"; break;
                        case 8: rom += "VIII"; break;
                        case 9: rom += "IX"; break;
                    }
                    n -= n;
                }
                else
                {
                    DisplayAlert("ALERTA!", "El número ingresado no esta dentro del rango", "OK");
                    v = false;
                    break;
                }
                if (n == 0)
                {
                    break;
                }
            }
            if (v)
            {
                lblMensaje.Text = "El número romano es: " + rom;
            }

        }
    }
}