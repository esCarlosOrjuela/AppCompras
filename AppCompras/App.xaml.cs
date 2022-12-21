namespace AppCompras;

public partial class App : Application
{
    public new static App Current => (App)Application.Current;
    public IServiceProvider ServiceProvider { get; }

    public App()
    {
        InitializeComponent();
        MainPage = new AppShell();
    }
}

