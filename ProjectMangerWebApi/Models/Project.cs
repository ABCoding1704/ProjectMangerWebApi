﻿using System.ComponentModel.DataAnnotations;

namespace ProjectMangerWebApi.Models
{
    public class Project
    {
        [Key]
        public int Id { get; set; }

        public string Name { get; set; } = null!;

        public string Description { get; set; }

        public List<Phase> Phases { get; set; }

        public DateTime StartDate { get; set; } = DateTime.Now;

        public DateTime EndDate { get; set; } = (DateTime.Now).AddDays(1);
    }
}
