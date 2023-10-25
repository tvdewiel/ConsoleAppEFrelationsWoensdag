using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEFrelationsWoensdag
{
    public class CityEF
    {
        public int Id { get; set; }
        public int? Population {  get; set; }
        public List<CityNameEF> Names { get; set; }=new List<CityNameEF>();
        //public bool IsCapital { get; set; }
        public CountryEF Country { get; set; }
        //public int? CountryCityId { get; set; }
        //public CountryEF CountryCity { get; set; }
        //public int? CapitalCityId { get; set; }
        //public CountryEF CapitalCity { get; set; }
    }
}
