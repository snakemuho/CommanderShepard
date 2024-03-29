﻿using System.ComponentModel.DataAnnotations;

namespace CommanderShepard.Models
{
    public class Command
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MaxLength(250)]
        public string HowTo { get; set; }
        [Required]
        [MaxLength(250)]
        public string Line { get; set; }
        [Required]
        [MaxLength(250)]
        public string Platform { get; set; }
    }
}
