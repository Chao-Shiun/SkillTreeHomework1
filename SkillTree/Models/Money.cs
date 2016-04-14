using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SkillTree.Models
{
    public class Money
    {
        [Required]
        [Display(Name = "金額")]
        public decimal Amount { get; set; }

        [Required]
        [Display(Name = "帳目類型")]
        public string Category { get; set; }

        [Required]
        [Display(Name = "異動時間")]
        public DateTime Date { get; set; }

        [Display(Name = "帳目敘述")]
        public string Description { get; set; }

        [Required]
        public int ID { get; set; }
    }
}