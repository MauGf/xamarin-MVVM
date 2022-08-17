using Delivery.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace Delivery.ViewModels
{
    public class MainPageViewModel : BaseViewModel
    {
        #region Variables
        //string _Texto;
        

        #endregion
        #region Constructor
        public MainPageViewModel(INavigation navigation)
        {
            Navigation = navigation;
        }
        #endregion
        #region Objetos

        #endregion

        #region Procesos
        public async Task Alerta()
        {
            await DisplayAlert("Titulo", "Bienvenido al Patron MVVM", "OK");
        }

        public async Task ir_pagina_2()
        {
            await Navigation.PushAsync(new DeliveryPage());
        }

        public void ProcesoSimple()
        {

        }
        #endregion

        #region Comandos
        public ICommand ir_pagina2_Command => new Command(async () => await ir_pagina_2());
        #endregion

    }
}
