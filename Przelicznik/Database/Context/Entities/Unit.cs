﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przelicznik.Database.Context.Entities
{
    class Unit
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Symbol { get; set; }

        public int UnitTypeId { get; set; }
        public UnitType UnitType123 { get; set; }
    }
}
