using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LifeBooks.Models;
using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace LifeBooks.ViewModels
{
    public partial class BookListViewModel : ObservableObject
    {
        public ObservableCollection<Book> Books { get; } = new();
        public BookListViewModel()
        {
            Books.Add(new Book
            {
                Title = "謎解き広報課",
                Author = "天祢涼",
                ISBN = "9784344434158",
                Publisher = "幻冬舎",
                Genre = "Fiction",
                Description = ""
            });
        }
    }
}