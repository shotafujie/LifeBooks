using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using LifeBooks.Models;

namespace LifeBooks.ViewModels;

public partial class BookRegistrationViewModel : ObservableObject
{
    [ObservableProperty]
    private string title;

    [ObservableProperty]
    private string author;

    [ObservableProperty]
    private string isbn;
    [ObservableProperty]
    private string publisher;
    [ObservableProperty]
    private string genre;

    [ObservableProperty]
    private string description;

    [ObservableProperty]
    private string registrationMessage;

    public Book RegisteredBook { get; set; } = new();
    
    private readonly BookRepository _bookRepository;

    public BookRegistrationViewModel()
    {
        string dbPath = Path.Combine(FileSystem.AppDataDirectory, "Books.db");
        _bookRepository = new BookRepository(dbPath);
    }

    /// <summary>
    /// 本の登録
    /// </summary>
    /// <returns></returns>
    [RelayCommand]
    private async Task Register()
    {
        RegisteredBook.Title = Title;
        RegisteredBook.Author = Author;
        //RegisteredBook.ISBN = ISBN;
        RegisteredBook.Publisher = Publisher;
        RegisteredBook.Genre = Genre;
        RegisteredBook.Description = Description;
        await _bookRepository.AddBookAsync(RegisteredBook);
        RegistrationMessage = "登録が完了しました。";
        await Shell.Current.GoToAsync("..");
    }
    /// <summary>
    /// 一覧画面に戻る
    /// </summary>
    /// <returns></returns>
    [RelayCommand]
    private async Task GoToListPage()
    {
        await Shell.Current.GoToAsync("..");
    }
}