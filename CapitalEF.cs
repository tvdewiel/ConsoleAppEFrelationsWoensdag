using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEFrelationsWoensdag
{
    public class CapitalEF
    {
        public int CityId { get; set; }
        public CityEF City { get; set; }
        public int CountryId { get; set; }
        public CountryEF Country { get; set; }
    }
}
