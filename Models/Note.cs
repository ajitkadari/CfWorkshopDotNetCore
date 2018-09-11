using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CfWorkshopDotNetCore.Models
{
    public class Note
    {

        public int ID { get; set; }

        [Required]
        public string Text { get; set; }

        [DisplayFormat(DataFormatString = "{0:g}")]
        [Column(TypeName = "timestamp")]
        public DateTime Created { get; set; }
    }
}