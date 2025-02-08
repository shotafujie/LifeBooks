using SQLite;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace LifeBooks.Models
{
    public class BookRepository
    {
        private SQLiteAsyncConnection _connection;

        public BookRepository(string dbPath)
        {
            _connection = new SQLiteAsyncConnection(dbPath);
            _connection.CreateTableAsync<Book>();
        }

        public async Task<int> AddBookAsync(Book book)
        {
            return await _connection.InsertAsync(book);
        }

        public async Task<List<Book>> GetBooksAsync()
        {
            return await _connection.Table<Book>().ToListAsync();
        }
    }
}