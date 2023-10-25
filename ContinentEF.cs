using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEFrelationsWoensdag
{
    public class ContinentEF
    {
        public int Id { get; set; }
        public int? Population {  get; set; }
        public int? Surface { get; set; }
        public List<CountryEF> Countries { get; set; } = new List<CountryEF>();
        public List<ContinentNameEF> Names { get; set; } = new List<ContinentNameEF>();
    }
}
