﻿using DotNetBookStore.Models;
using System.ComponentModel.DataAnnotations;

namespace DotNetBookstore.Models
{
    public class Book
    {
        //PK
        public int BookId { get; set; }

        //these work for Author below
        [Required]
        [MaxLength(100)]
        public string Author { get; set; }

        [Required]
        [MaxLength(200)]
        
        public string Title { get; set; }

        public string? Image { get; set; }

        [Required]
        [Range(0.01, 999999)]

        //c = currency format
        // 0 is placeholder for amount of price ?
        [DisplayFormat(DataFormatString ="{0:c}")]
        public decimal Price { get; set; }

        public bool MatureContent { get; set; }

        //FK
        public int CategoryId { get; set; }


        //child and parent references have to be declared in both model classes. Two way.
        // child references
        public List<CartItem>? CartItems { get; set; }
        public List<OrderDetail>? OrderDetails { get; set; }

        // parent reference
        public Category? Category { get; set; }
    }
}