using System;
using System.ComponentModel.DataAnnotations;

namespace Shop.Models
{
    public class Mail
    {
        public int Id { get; set; }

        [Required]
        public string Title { get; set; }

        public string Content { get; set; }

        [Required]
        public string Receiver { get; set; }
    }
}