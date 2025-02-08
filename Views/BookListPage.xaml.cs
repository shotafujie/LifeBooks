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
    /// ÉyÅ[ÉWëJà⁄èàóù
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private async void GoToRegistrationPage(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(BookRegistrationPage));
    }
    private void BookListPage_Appearing(object sender, EventArgs e)
    {
        var viewModel = (BookListViewModel)BindingContext;
        viewModel.LoadBooksAsync();
    }
}