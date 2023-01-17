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
        //AC_LoadData();
        BindingContext = this;
    }

    private void AC_LoadData()
    {
        List<AC_Burger> burger = App.BurgerRepo.AC_GetAllBurgers();
        ACburgerList.ItemsSource = burger;
        burger = App.BurgerRepo.AC_GetAllBurgers();
        ACburgerList.ItemsSource = burger;
    }

    protected override void OnAppearing()
    {
        AC_LoadData();
    }

    public void AC_OnItemAdded(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync(nameof(BurgerItemPage), true, new Dictionary<string, object>
        {
            ["Item"] = new AC_Burger()
        });
        base.OnAppearing();
    }

    async void AC_CollectionView_SelectionChanged(object sender, SelectionChangedEventArgs e)
    {
        var selected = e.CurrentSelection[0] as AC_Burger;
        if (selected != null)
        {
            await Shell.Current.GoToAsync(nameof(BurgerItemPage));
            base.OnAppearing();
        }

    }
}