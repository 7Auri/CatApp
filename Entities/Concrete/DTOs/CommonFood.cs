﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete.DTOs
{
    public class CommonFood : IDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Kind { get; set; }
        public Cat Cat { get; set; }
    }
}
