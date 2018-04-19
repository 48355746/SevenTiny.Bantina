﻿using SevenTiny.Bantina.Bankinate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Test.SevenTiny.Bantina.Model
{
    public class Student
    {
        [AutoIncrease]
        [Key]
        public int Id { get; set; }
        [Column]
        public string Name { get; set; }
        [Column]
        public int Age { get; set; }
        public int BodyHigh { get; set; }
        public int HealthLevel { get; set; }

        public string GetName()
        {
            return this.Name;
        }
    }
}
