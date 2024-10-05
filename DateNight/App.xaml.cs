using DateNight.Models;
namespace DateNight;
public partial class App : Application
{
    public static DateCalculator DateCalc;
    
    public App()
    {
        InitializeComponent();
        DateCalc = new DateCalculator();
        MainPage = new AppShell();
    }
}