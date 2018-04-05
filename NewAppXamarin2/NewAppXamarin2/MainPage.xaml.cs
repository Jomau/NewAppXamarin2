using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace NewAppXamarin2
{
	public partial class MainPage : ContentPage
	{
        private Boolean estado;
		public MainPage()
		{
			InitializeComponent();
            estado = false;
		}

        public void OnButtonClicked(object sender, EventArgs a) {
            estado = !estado;
            msgLabel.Text = estado?"Hola mundo": "Adiós mundo";
        }
	}
}
