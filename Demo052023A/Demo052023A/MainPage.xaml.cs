using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Demo052023A
{
    public partial class MainPage : ContentPage
    {
        bool CambioColor = true;
        public MainPage()
        {
            InitializeComponent();

            dtpFechaNacimiento.MaximumDate = DateTime.Today;

            

        }

        private void btnGirar_Clicked(object sender, EventArgs e)
        {
            if (CambioColor)
                lblPrueba.TextColor = Color.Blue;
            else
                lblPrueba.TextColor = Color.Red;
            
            CambioColor=!CambioColor;
            
        }
    }
}
