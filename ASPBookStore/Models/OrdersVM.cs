using ASPBookStore.Data;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ASPBookStore.Models
{
    public class OrdersVM
    {
        public int Id { get; set; }


        public int UserId { get; set; }


        [Required(ErrorMessage = "This message is required!")]
        public int ProductId { get; set; }
        public List<SelectListItem> Product { get; set; }

        [Required(ErrorMessage = "This message is required!")]
        public int AmountOrdered { get; set; }
         
        [Required(ErrorMessage = "This message is required!")]
        public decimal PriceOrder { get; set; }
       
        [Required(ErrorMessage = "This message is required!")]
        [DataType(DataType.Date)]
        [Display(Name = "Дата на закупуване: ")]
        public DateTime OrderedOn { get; set; }
    }
}
