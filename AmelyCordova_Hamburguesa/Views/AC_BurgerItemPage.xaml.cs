using AmelyCordova_Hamburguesa.Data;
using AmelyCordova_Hamburguesa.Models;

namespace AmelyCordova_Hamburguesa.Views;

[QueryProperty("Item", "Item")]//propiedad que recibe el dato/el dato

public partial class AC_BurgerItemPage : ContentPage
{
    public AC_Burger Item
    {
        get => BindingContext as AC_Burger;
        set => BindingContext = value;
    }

    //Burger Item = new Burger();
    //bool _flag;

    public AC_BurgerItemPage()
    {
        InitializeComponent();
    }

    /*private void AC_OnCheckBoxCheckedChanged(object sender, CheckedChangedEventArgs e)
	{
        _flag = e.Value;
	}*/

    private void AC_OnSaveClicked(object sender, EventArgs e)
    {
        //La actualización ya s erealiza en la parte de arriba
        //Item.Name = ACnameB.Text;
        //Item.Description = ACdescB.Text;
        //Item.WithExtraCheese = _flag;
        App.BurgerRepo.AC_AddNewBurger(Item);
        Shell.Current.GoToAsync("..");
    }

    private void AC_OnCancelClicked(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("..");
    }

    private void AC_OnDeleteClicked(object sender, EventArgs e)
    {
        App.BurgerRepo.AC_DeleteItem(Item);
        Shell.Current.GoToAsync("..");
    }
}