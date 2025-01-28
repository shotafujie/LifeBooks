using LifeBooks.Views;
namespace LifeBooks
{
    public partial class AppShell : Shell
    {
        public AppShell()
        {
            InitializeComponent();
            Routing.RegisterRoute(nameof(BookRegistrationPage), typeof(BookRegistrationPage));
        }
    }
}
