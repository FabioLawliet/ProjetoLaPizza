﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LaPizza.Models
{
    public class SubgrupoModel
    {
        public int id { get; set; }
        public string descricao { get; set; }
        public int grupo { get; set; }
        public bool ativo { get; set; }   

    }
}
