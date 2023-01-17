using AmelyCordova_Hamburguesa.Models;
using System.Collections.Generic;

namespace AmelyCordova_Hamburguesa.Views;

public partial class BurgerListPage : ContentPage
{
    public BurgerListPage()
    {
        InitializeComponent();
        //List<Burger> burger = App.BurgerRepo.GetAllBurgers();
        //ACburgerList.ItemsSource = burger;
        AC_LoadData();
    }

    private void AC_LoadData()
    {
        List<Burger> burger = App.BurgerRepo.GetAllBurgers();
        ACburgerList.ItemsSource = burger;
        burger = App.BurgerRepo.GetAllBurgers();
        ACburgerList.ItemsSource = burger;
    }

    protected override void OnAppearing()
    {
        AC_LoadData();
    }

    async void AC_OnItemAdded(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(BurgerItemPage));
        base.OnAppearing();
    }

    async void AC_CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        var selected = e.CurrentSelection[0] as Burger;
        if (selected != null)
        {
            await Shell.Current.GoToAsync(nameof(BurgerItemPage));
            base.OnAppearing();
        }

    }
}