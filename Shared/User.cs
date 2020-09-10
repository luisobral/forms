using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Forms.Shared
{
    public class Usuario
    {
        [Required]
        public string Title { get; set;}
        [Required]
        public string First { get; set; }
        [Required]
        public string Last { get; set; }
        [Required]
        public DateTime Birthday { get; set; }
        [Required]
        [EmailAddress] 
        public string Email { get; set; }
        [Required]
        [MinLength(8,ErrorMessage ="A senha necessária é de no mínimo 8 caracteres")]
        public string Password { get; set; }
        [Required]
        public string Confirm { get; set; }
        [Required]
        [Range(typeof(bool), "true", "true", ErrorMessage = "É necessário aceitar os termos de uso")]
        public bool Terms { get; set; }

    }
}
