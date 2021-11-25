using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace KAIZEN_PA.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Errores : ContentPage
    {
        public Errores()
        {
            InitializeComponent();
        }
        public void prueba()
        {

            switch (error.Text)
            {
                case "1":
                    fallas.Text = "la falla numero 1  \n" +
                        "es falta sensor de pata delantera derecha porfavor verifique el estado del sensor \n"+
                        "o su ajuste sea el indicado o con el codigo de la falla que es 001 dirigase a esta url https//:www.google.com";
                    fallas.TextColor = Color.Red;

                break;

                case "2":
                    fallas.Text = "la falla numero 2  \n" +
                        "falta presencia cabina con el codigo 002 dirigase a esta url https//:www.google.com";
                    fallas.TextColor = Color.Blue;
                    break;

            }
        }

        private void PULSO(object sender, EventArgs e)
        {
            prueba();
        }
    }
}