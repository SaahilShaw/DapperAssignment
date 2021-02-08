using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace DapperUi.Models
{
    public class Student
    {
        [Required(ErrorMessage = "Please enter correct id")]
        public int Id { get; set; }
        [Required(ErrorMessage = "Please enter correct Name")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please enter correct Gender")]
        public string Gender { get; set; }
        [Required(ErrorMessage = "Please enter correct Age")]
        public int Age { get; set; }
    }
}