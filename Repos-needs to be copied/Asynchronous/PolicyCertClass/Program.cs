using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolicyCertClass
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public class Config
    {
        public List<PageType> pages{ get; set; }
        public List<StaticVariant> staticVarinats { get; set; }
    }
    public class PageType
    {
        public string Name { get; set; }
        public List<Variant> variants { get; set; }
    }
    public class Variant
    {
        public string variatioName { get; set; }
        public string sourceTable { get; set; }
        public string dataTextField { get; set; }
        public string dataValueField { get; set; }

    }

    public class StaticVariant
    {
        public string name { get; set; }
        public string factor { get; set; }
    }
}
