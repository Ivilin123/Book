using System.Collections.Generic;

namespace ASPBookStore.Data
{
    public class Author
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual ICollection<Product> Products { get; set; }
    }
}
