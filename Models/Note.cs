using System;
using System.ComponentModel.DataAnnotations;

namespace CfWorkshopDotNetCore.Models
{
    public class Note
    {

        public int ID { get; set; }

        [Required]
        public string Text { get; set; }

        [DisplayFormat(DataFormatString = "{0:g}")]
        public DateTime Created { get; set; }
    }
}