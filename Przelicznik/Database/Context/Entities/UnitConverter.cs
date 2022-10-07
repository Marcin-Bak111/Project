using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Przelicznik.Database.Context.Entities
{
    class UnitConverter
    {
        public int Id { get; set; }
        public float ConvertValue { get; set; }

        public int SourceUnitId { get; set; }
        public int SourceUnit { get; set; }

        public int TargetUnitId { get; set; }
        public int TargetUnit { get; set; }
    }
}
