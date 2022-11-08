namespace Popoviciu_Andreea_Lab2.Models.ViewModels
{
    public class CategoriesIndexData
    {
        public IEnumerable<Category> Categories { get; set; }
        public IEnumerable<Book> Books { get; set; }
        public IEnumerable<BookCategory> BookCategories { get; set; }
    }
}
