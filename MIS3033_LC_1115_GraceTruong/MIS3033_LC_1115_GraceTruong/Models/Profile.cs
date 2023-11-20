﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace a
{
    public class Profile
    {
        [Key]   
        public string Id { get; set; }

        [ForeignKey(nameof(Student))]
        public string StudentID { get; set; } //  foreign key
        public Student Student { get; set; } // this is not mandatory, this is not going to be saved to the database

        public string fcolor { get; set; }
        public string address { get; set; }
        public double lon { get; set; }
        public double lat { get; set; }
        public double height { get; set; }
        public double weight { get; set; }

        public DateTime created { get; set; }


    }
}
