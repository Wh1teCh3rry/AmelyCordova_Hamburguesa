using AmelyCordova_Hamburguesa.Views;

namespace AmelyCordova_Hamburguesa;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        Routing.RegisterRoute(nameof(BurgerItemPage), typeof(BurgerItemPage));
    }
}