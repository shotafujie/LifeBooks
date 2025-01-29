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
                Description = "おもしろかった",
                BeginingDay = new DateTime(2025, 1, 28),
                EndDay = new DateTime(2025, 2, 28)
            });
            Books.Add(new Book
            {
                Title = "浜村渚の計算ノート",
                Author = "青柳 碧人",
                ISBN = "9784062769815",
                Publisher = "講談社",
                Genre = "Math",
                Description = "数学",
                BeginingDay = new DateTime(2025, 1, 12),
                EndDay = new DateTime(2025, 2, 8)
            });
            Books.Add(new Book
            {
                Title = "みんなでアジャイル",
                Author = "Matt LeMay",
                ISBN = "9784873119090",
                Publisher = "オライリージャパン",
                Genre = "Tech",
                Description = "Agileやるときにまず読む本",
                BeginingDay = new DateTime(2025, 1, 18),
                EndDay = new DateTime(2025, 1, 28)
            });
            Books.Add(new Book
            {
                Title = "謎解き広報課",
                Author = "天祢涼",
                ISBN = "9784344434158",
                Publisher = "幻冬舎",
                Genre = "Fiction",
                Description = "おもしろかった",
                BeginingDay = new DateTime(2025, 1, 28),
                EndDay = new DateTime(2025, 2, 28)
            });
            Books.Add(new Book
            {
                Title = "浜村渚の計算ノート",
                Author = "青柳 碧人",
                ISBN = "9784062769815",
                Publisher = "講談社",
                Genre = "Math",
                Description = "数学",
                BeginingDay = new DateTime(2025, 1, 12),
                EndDay = new DateTime(2025, 2, 8)
            });
            Books.Add(new Book
            {
                Title = "みんなでアジャイル",
                Author = "Matt LeMay",
                ISBN = "9784873119090",
                Publisher = "オライリージャパン",
                Genre = "Tech",
                Description = "Agileやるときにまず読む本",
                BeginingDay = new DateTime(2025, 1, 18),
                EndDay = new DateTime(2025, 1, 28)
            }); 
            Books.Add(new Book
            {
                Title = "謎解き広報課",
                Author = "天祢涼",
                ISBN = "9784344434158",
                Publisher = "幻冬舎",
                Genre = "Fiction",
                Description = "おもしろかった",
                BeginingDay = new DateTime(2025, 1, 28),
                EndDay = new DateTime(2025, 2, 28)
            });
            Books.Add(new Book
            {
                Title = "浜村渚の計算ノート",
                Author = "青柳 碧人",
                ISBN = "9784062769815",
                Publisher = "講談社",
                Genre = "Math",
                Description = "数学",
                BeginingDay = new DateTime(2025, 1, 12),
                EndDay = new DateTime(2025, 2, 8)
            });
            Books.Add(new Book
            {
                Title = "みんなでアジャイル",
                Author = "Matt LeMay",
                ISBN = "9784873119090",
                Publisher = "オライリージャパン",
                Genre = "Tech",
                Description = "Agileやるときにまず読む本",
                BeginingDay = new DateTime(2025, 1, 18),
                EndDay = new DateTime(2025, 1, 28)
            });
            Books.Add(new Book
            {
                Title = "謎解き広報課",
                Author = "天祢涼",
                ISBN = "9784344434158",
                Publisher = "幻冬舎",
                Genre = "Fiction",
                Description = "おもしろかった",
                BeginingDay = new DateTime(2025, 1, 28),
                EndDay = new DateTime(2025, 2, 28)
            });
            Books.Add(new Book
            {
                Title = "浜村渚の計算ノート",
                Author = "青柳 碧人",
                ISBN = "9784062769815",
                Publisher = "講談社",
                Genre = "Math",
                Description = "数学",
                BeginingDay = new DateTime(2025, 1, 12),
                EndDay = new DateTime(2025, 2, 8)
            });
            Books.Add(new Book
            {
                Title = "みんなでアジャイル",
                Author = "Matt LeMay",
                ISBN = "9784873119090",
                Publisher = "オライリージャパン",
                Genre = "Tech",
                Description = "Agileやるときにまず読む本",
                BeginingDay = new DateTime(2025, 1, 18),
                EndDay = new DateTime(2025, 1, 28)
            });
        }
    }
}