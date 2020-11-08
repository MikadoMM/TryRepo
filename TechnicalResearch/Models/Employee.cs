using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TechnicalResearch.Models
{
    public class Employee
    {
        [Key]
        [DisplayName("ID")]
        public int id { get; set; }

        [DisplayName("従業員名")]
        [Required(ErrorMessage = "名前は必須入力です")]
        [StringLength(10, ErrorMessage = "{0}は{1}文字以内で入力してください。")]
        [CustomValidation(typeof(Employee), "CheckName")]
        public string name { get; set; }

        public static ValidationResult CheckName(string value, ValidationContext context)
        {
            var model = (Employee)context.ObjectInstance;
            if(model.name == "makoto")
            {
                return new ValidationResult("Stupid");
            }
            return ValidationResult.Success;
        }
    }
}