using AmelyCordova_Hamburguesa.Data;

namespace AmelyCordova_Hamburguesa;

public partial class App : Application
{
	public static BurgerDatabase BurgerRepo { get; set; }

	public App(BurgerDatabase repo)
	{
		InitializeComponent();

		MainPage = new AppShell();
		BurgerRepo = repo;
	}
}