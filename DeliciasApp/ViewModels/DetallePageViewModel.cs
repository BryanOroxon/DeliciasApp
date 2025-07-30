using DeliciasApp.Models;
using System.Windows.Input;

namespace DeliciasApp.ViewModels;

//[QueryProperty(nameof(PueblaDish), "PueblaDish")]
public  class DetallePageViewModel:BaseViewModel
{
   
    public PueblaDish SelectedDish { get; set; }
    
    public string Nombre { get; set; }
    public string Descripcion { get; set; }
    public string ImagenUrl { get; set; }

    public ICommand CloseCommand => new Command(() =>
    Microsoft.Maui.Controls.Application.Current.MainPage.Navigation.PopAsync());
}
