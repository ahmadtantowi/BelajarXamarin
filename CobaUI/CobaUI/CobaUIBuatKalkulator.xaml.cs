using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CobaUI
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CobaUIBuatKalkulator : ContentPage
	{
		public CobaUIBuatKalkulator ()
		{
			InitializeComponent ();
		}

        public void Kalkulasi (object sender, EventArgs e)
        {
            double hasil = 0;
            var oprtr = (Button)sender;

            switch (oprtr.Text)
            {
                case "+":
                    hasil = Convert.ToDouble(etrBil1.Text) + Convert.ToDouble(etrBil2.Text);
                    break;
                case "-":
                    hasil = Convert.ToDouble(etrBil1.Text) - Convert.ToDouble(etrBil2.Text);
                    break;
                case "x":
                    hasil = Convert.ToDouble(etrBil1.Text) * Convert.ToDouble(etrBil2.Text);
                    break;
                case "/":
                    hasil = Convert.ToDouble(etrBil1.Text) / Convert.ToDouble(etrBil2.Text);
                    break;
            }
            etrHasil.Text = hasil.ToString();
        }
	}
}