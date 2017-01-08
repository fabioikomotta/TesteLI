using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using LaudoImagem.Mobile.ViewModel;

namespace LaudoImagem.Mobile
{
    public partial class ExamesPage : ContentPage
    {
        public ExamesViewModel Model;

        public ExamesPage()
        {
            InitializeComponent();

            Model = new ExamesViewModel();

        }
    }
}
