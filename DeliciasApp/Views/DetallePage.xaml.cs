using DeliciasApp.ViewModels;

namespace DeliciasApp.Views;

public partial class DetallePage : ContentPage
{
	public DetallePage(Models.PueblaDish selectedDish)
	{
		InitializeComponent();
		var viewModel = new DetallePageViewModel() { SelectedDish = selectedDish };
		viewModel.Nombre = selectedDish.Nombre;
		viewModel.Descripcion = selectedDish.Descripcion;
		viewModel.ImagenUrl = selectedDish.ImagenUrl;
        this.BindingContext = viewModel;
    }
}