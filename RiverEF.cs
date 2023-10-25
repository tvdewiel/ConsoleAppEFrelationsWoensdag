using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEFrelationsWoensdag
{
    public class RiverEF
    {
        public int Id { get; set; }
        public string? Mouth {  get; set; }
        public string? Source { get; set; }
        public List<CountryEF> Countries { get; set; }=new List<CountryEF>();
        public List<CountryRiverEF> CountryRivers { get; set; } =new List<CountryRiverEF>();
    }
}
