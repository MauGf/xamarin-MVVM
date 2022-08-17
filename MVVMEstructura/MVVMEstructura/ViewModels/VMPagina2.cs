using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using MVVMEstructura.Views;

namespace MVVMEstructura.ViewModels
{
    public class VMpagina2 : BaseViewModel
    {
        #region Variables
        string _Texto;
        #endregion
        #region Constructor
        public VMpagina2(INavigation navigation)
        {
            Navigation = navigation;
        }
        #endregion
        #region Objetos
        public string Texto
        {
            get { return _Texto; }
            set { SetValue(ref _Texto, value); }
        }
        #endregion
        #region Procesos
        public async Task Volver()

        {
            await Navigation.PopAsync();
        }
        public void ProcesoSimple()
        {

        }
        #endregion
        #region Comandos
        public ICommand Volvercommand => new Command(async () => await Volver());
        public ICommand ProcesoSimplecommand => new Command(ProcesoSimple);
        #endregion

    }
}
