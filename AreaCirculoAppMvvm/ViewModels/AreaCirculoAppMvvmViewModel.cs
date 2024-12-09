

using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;

namespace AreaCirculoAppMvvm.ViewModels
{
    public partial class AreaCirculoAppMvvmViewModel: ObservableObject
    {
        [ObservableProperty]
        public double a;

        [ObservableProperty]
        public double total;

        private void Alerta(string Titulo, string Mensaje)
        {
            MainThread.BeginInvokeOnMainThread(async () => await App.Current!.MainPage!.DisplayAlert(Titulo, Mensaje, "Aceptar"));
        }

        [RelayCommand]
        private void Calcular()
        {

            try
            {

                Total = A * Math.PI;


            }


            catch (Exception ex)
            {
                Alerta("ERROR", ex.Message);
            }
        }
        [RelayCommand]
        private void Limpiar()
        {
            A= 0;
            Total = 0;

        }
    }
}
