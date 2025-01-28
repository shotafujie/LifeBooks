using LifeBooks.ViewModels;
namespace LifeBooks.Views;

public partial class BookListPage : ContentPage
{
    public BookListPage()
    {
        InitializeComponent();
        BindingContext = new BookListViewModel();
    }
    /// <summary>
    /// ƒy[ƒW‘JˆÚˆ—
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private async void GoToRegistrationPage(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(BookRegistrationPage));
    }
}