﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model
{
    public class Cliente
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int Idade { get; set; }


        public override string ToString()
        {
            return $"{Id}- {Name} ({Email}, {Idade} anos)";

        }
    }
}
