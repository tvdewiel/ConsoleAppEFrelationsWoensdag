using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppEFrelationsWoensdag
{
    public class CountryEF
    {
        public int Id { get; set; }
        public int Population { get; set; }
        public int Surface { get; set; }
        //public List<ContinentEF> Continents { get; set; }=new List<ContinentEF>();
        public List<CountryNameEF> Names { get; set; }= new List<CountryNameEF>();
        public List<CityEF> Cities { get; set; } = new List<CityEF>();
        //public List<CityEF> Capitals { get; set; } = new List<CityEF>();
        public List<CapitalEF> Capitals { get; set; }=new List<CapitalEF>();
        public List<RiverEF> Rivers { get; set; }=new List<RiverEF>();
    }
}
