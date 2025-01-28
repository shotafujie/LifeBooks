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

    [RelayCommand]
    private void Register()
    {
        RegisteredBook.Title = Title;
        RegisteredBook.Author = Author;
        //RegisteredBook.ISBN = ISBN;
        RegisteredBook.Publisher = Publisher;
        RegisteredBook.Genre = Genre;
        RegisteredBook.Description = Description;

        RegistrationMessage = "登録が完了しました。";

    }
}