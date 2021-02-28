using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Interfaces.Streaming;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CodeFirst
{
    public class Model
    {
        public class Customer
        {
            public int CustomerId { get; set; }

            [Required]
            [MaxLength(20)]
            public string FirstName { get; set; }
            public string LastName { get; set; }

            [Range(14, 100)]
            public int Age { get; set; }

            [MaxLength(100)]
            public string Email { get; set; }
            public string PhoneNumber { get; set; }

           //public byte[] Photo { get; set; }
            public override string ToString()
            {
                string s = FirstName + " " + LastName + ", электронный адрес: " + Email + ", телефон: " + PhoneNumber;
                return s;
            }
            // Ссылка на заказы
            public virtual List<Order> Orders { get; set; }
            public Customer()
            {
                Orders = new List<Order>();
            }
        }

        public class Order
        {
            public int OrderId { get; set; }
            public string ProductName { get; set; }
            public string Description { get; set; }
            public decimal UnitPrice { get; set; } //цена за единицу товара
            public int Quantity { get; set; }
            public DateTime PurchaseDate { get; set; }
            // Ссылка на покупателя
            public Customer Customer { get; set; }
            public override string ToString()
            {
                string s = ProductName + " " + Quantity + "шт., " + UnitPrice + "за ед. " + PurchaseDate;
                return s;
            }
        }
    }
}