
namespace WebApplication1.Entities
{
    public static class Extensions
    {
        public static BookDto AsDto(this Book book)
        {
            return new BookDto(){Id= book.Id, Title=book.Title, year=book.Year,Description= book.Description };
        }

    }
}
