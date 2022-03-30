using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BlogAtilio.MVC.Models
{
    public class Topic
    {
        [Key]
        public Guid Id { get; set; }
        [Required, MaxLength(200, ErrorMessage = "Title não pode exceder 200 caracteres")]
        public string Title { get; set; }

        [Required, MaxLength(5000, ErrorMessage = "Descrição não pode exceder 5000 caracteres")]
        public string Description { get; set; }

        [Required]
        public string CreateById { get; set; }
        public IdentityUser CreateBy { get; set; }
        
        [Required]
        public DateTimeOffset CreateAt { get; set; }
    }
}
