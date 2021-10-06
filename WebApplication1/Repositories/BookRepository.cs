using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;
using WebApplication1.Entities;

namespace WebApplication1.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly AuthenticationContext _context;
        public BookRepository(AuthenticationContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Book>> GetBooksAsync()
        {
            return await _context.Books.ToListAsync();
        }

        public IList<Book> GetBookAsync(int Id)
        {
            return _context.Books.Where(p => p.Id == Id).ToList();
        }
    }
}
