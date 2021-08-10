using System;
using System.ComponentModel.DataAnnotations;

namespace DojoForm.Models
{
    public class User
    {
        //UserName
        [Required]
        [Display(Name = "Name")]
        [MinLength(2, ErrorMessage = "You need at least 2 characters in Name")]
        public string UserName {get;set;}
        //UserDojo
        [Required]
        [Display(Name = "Dojo Lcation")]
        public string UserDojo {get;set;}
        //FavLanguage
        [Required]
        [Display(Name = "Favorite Language")]
        public string FavLanguage {get;set;}
        //Comment
        [MaxLength(20, ErrorMessage = "Yor Comment must be under 20 characters")]
        public string Comment {get;set;}
    }
}