using DeliciasApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace DeliciasApp.ViewModels;

public class MainPageViewModel : BaseViewModel
{
    private List<PueblaDish> _allDishes => DishesRepo.AllDishes;

    public ObservableCollection<PueblaDish> Dishes { get; set; }

    public PueblaDish SelectedDish { get; set; }

    public ICommand DishSelected => new Command(obj =>
    {
        if (SelectedDish != null)
            Application.Current.MainPage.Navigation.PushAsync(new DetallePage
                (SelectedDish));
        SelectedDish = null;
    });

    private string _searchText;
    public string SearchText
    {
        get => _searchText;
        set
        {
            if (_searchText != value)
            {
                _searchText = value;
                OnPropertyChanged();
                // Optionally, filter your dishes here
                FilterDishes();
            }
        }
    }

    public MainPageViewModel()
    {
        Dishes = new ObservableCollection<PueblaDish>(_allDishes);
    }

    private void FilterDishes()
    {
        string texto = _searchText?.ToLower() ?? "";
        var lista = _allDishes.Where(d => d.Nombre.ToLower().Contains(texto));
        Dishes.Clear();
        foreach (var d in lista)
            Dishes.Add(d);
    }
}

