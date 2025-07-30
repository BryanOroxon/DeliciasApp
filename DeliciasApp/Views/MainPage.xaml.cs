using DeliciasApp.ViewModels;

namespace DeliciasApp
{
    public partial class MainPage : ContentPage
    {


        public MainPage()
        {
            InitializeComponent();
            this.BindingContext = new MainPageViewModel();
        }

        
    }
}
