﻿using System;
using System.ComponentModel.DataAnnotations;
using WebApplication1.Entities;

namespace WebApplication1.Entities
{
    public class BookDto {
        public int Id { get; set; }
        public string Title { get; set; }
        public int year { get; set; }
        public string Description { get; set; }
           
       }
    public class CreateBookDto
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public int year { get; set; }
        public string Description { get; set; }

    }
    public class UpdateBookDto
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public int year { get; set; }
        public string Description { get; set; }

    }

    public class CreateInstance
    {

       

    }

}
