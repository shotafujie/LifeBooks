using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;
using System.Threading.Tasks;
using LifeBooks.Models;

namespace LifeBooks.ViewModels
{
    public partial class BookListViewModel : ObservableObject
    {
        [ObservableProperty]
        private ObservableCollection<Book> books = new();

        private readonly BookRepository _bookRepository;

        public BookListViewModel()
        {
            string dbPath = Path.Combine(FileSystem.AppDataDirectory, "Books.db");
            _bookRepository = new BookRepository(dbPath);

            LoadBooksAsync();
        }

        private async Task LoadBooksAsync()
        {
            try
            {
                var bookList = await _bookRepository.GetBooksAsync();
                Books = new ObservableCollection<Book>(bookList);
            }
            catch (System.Exception ex)
            {
                Console.WriteLine($"Error loading books: {ex.Message}");
                // 例えば、エラーメッセージを表示する、ログに出力するなどの処理を追加
                //await Shell.Current.DisplayAlert("Error", "Failed to load books.", "OK");
            }
        }
    }
}