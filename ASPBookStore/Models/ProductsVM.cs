using ASPBookStore.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ASPBookStore.Models
{
    public class ProductsVM
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int AuthorId { get; set; }
        public List<SelectListItem> Author { get; set; }
        public Covers Covers { get; set; }
        [EnumDataType(typeof(Covers))]
        public Types Types { get; set; }
        [EnumDataType(typeof(Types))]
        public int PublisherId { get; set; }
        public List<SelectListItem> Publisher { get; set; }
        public int PublishingYear { get; set; }
        public int CategoryId { get; set; }
        public List<SelectListItem> Category { get; set; }
        
        public int Amount { get; set; }
        public string Summary { get; set; }
        public string ImageURL { get; set; }
        public decimal Price { get; set; }

        public virtual ICollection<SelectListItem> Orders { get; set; }
    }
}
