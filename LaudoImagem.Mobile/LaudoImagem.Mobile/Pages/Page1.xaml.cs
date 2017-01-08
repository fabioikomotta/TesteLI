using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace LaudoImagem.Mobile
{
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();

            //editor1.SetValue(IsFocusedProperty, true);
        }


        private void swFinalizado_Toggled(object sender, ToggledEventArgs e)
        {
            Switch sw = (Switch)sender;
            editor1.IsEnabled = !sw.IsToggled;
        }
    }
}
