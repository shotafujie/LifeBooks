using LifeBooks.ViewModels;
namespace LifeBooks.Views;

public partial class BookListPage : ContentPage
{
    public BookListPage()
    {
        InitializeComponent();
        BindingContext = new BookListViewModel();
    }
}