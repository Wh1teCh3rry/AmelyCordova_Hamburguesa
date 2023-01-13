using AmelyCordova_Hamburguesa.Models;

namespace AmelyCordova_Hamburguesa.Views;

public partial class BurgerItemPage : ContentPage
{
    Burger Item = new Burger();
    bool _flag;

    public BurgerItemPage()
	{
		InitializeComponent();
	}

	private void AC_OnCheckBoxCheckedChanged(object sender, CheckedChangedEventArgs e)
	{
        _flag = e.Value;
	}

	private void AC_OnSaveClicked(object sender, EventArgs e)
	{
        Item.Name = ACnameB.Text;
        Item.Description = ACdescB.Text;
        Item.WithExtraCheese = _flag;
        App.BurgerRepo.AddNewBurger(Item);
        Shell.Current.GoToAsync("..");
    }

    private void AC_OnCancelClicked(object sender, EventArgs e)
	{
        Shell.Current.GoToAsync("..");
    }
}