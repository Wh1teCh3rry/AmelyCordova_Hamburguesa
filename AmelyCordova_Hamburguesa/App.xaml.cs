using AmelyCordova_Hamburguesa.Data;

namespace AmelyCordova_Hamburguesa;

public partial class App : Application
{
	public static AC_BurgerDatabase BurgerRepo { get; set; }

	public App(AC_BurgerDatabase repo)
	{
		InitializeComponent();

		MainPage = new AppShell();
		BurgerRepo = repo;
	}
}