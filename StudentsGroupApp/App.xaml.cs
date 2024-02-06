namespace StudentsGroupApp;

public partial class App : Application
{
    public const string DATABASE_NAME = "Scientific_Conference.db";
    public static TablesRep database;
    public static TablesRep Database
    {
        get
        {
            if (database == null)
            {
                database = new TablesRep(
                    Path.Combine(
                        Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), DATABASE_NAME));
            }
            return database;
        }
    }
    public App()
    {
        InitializeComponent();
        MainPage = new NavigationPage(new MainPage());
    }
}
