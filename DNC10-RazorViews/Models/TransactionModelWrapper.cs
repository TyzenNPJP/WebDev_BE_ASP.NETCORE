using DNC10_RazorViews.Models;

namespace DNC10_RazorViews.Models
{
    // A modelWrapper class to contain more than one var or obj to pass on to view pages
    public class TransactionModelWrapper
    {
        public Person? personData { get; set; }
        public Book? bookData { get; set; }
    }
}
