using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication25
{
    class Product
    {
        public int ProdId;
        public string ProdName;
        public Product(int ProdId, string ProdName)
        {
            ProdId = ProdId;
            ProdName = ProdName;
        }
    }
    class Provider
    {
        public int ProvId;
        public string ProvName;
        public Provider(int ProvId, string ProvName)
        {
            ProvId = ProvId;
            ProvName = ProvName;
        }
    }
    class Delivery
    {
        public int ProdId;
        public int ProvId;
        public string Date;
        public int ProdCount;
        public Delivery(int ProdId, int ProvId, string Date, int ProdCount)
        {
            ProdId = ProdId;
            ProvId = ProvId;
            Date = Date;
            ProdCount = ProdCount;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> prod = new List<Product>() { new Product(1, "Kefir"), new Product(2, "Memory"), new Product(3, "Lists")};
            List<Provider> prov = new List<Provider>() { new Provider(11, "OMGTU"), new Provider(12, "Logitec")};
            List<Delivery> deliv = new List<Delivery>() { new Delivery(1, 11, "01.06.2023", 100), new Delivery(2, 11, "01.06.2023", 50), new Delivery(3, 12, "23.05.2023", 1000) };
            var ANS1 = from a in deliv
                        join s in prod on a.ProdId equals s.ProdId
                        join p in prov on a.ProvId equals p.ProvId
                        where a.Date == "01.06.2023"
                        select new {ProdName = s.ProdName, ProvName = p.ProvName, ProdCount = a.ProdCount};
            foreach(var item in ANS1)
            {
                Console.WriteLine("{0}, {1}: {2}", item.ProvName, item.ProdName, item.ProdCount);
            }
            var ANS2 = from a in deliv
                       join s in prod on a.ProdId equals s.ProdId
                       join p in prov on a.ProvId equals p.ProvId
                       where a.ProdId == 1
                       select new { ProvName = p.ProvName };
            foreach (var item in ANS2)
            {
                Console.WriteLine("{0}", item.ProvName);
            }
            var ANS3 = from a in deliv
                       join s in prod on a.ProdId equals s.ProdId
                       join p in prov on a.ProvId equals p.ProvId
                       where a.ProvId == 11
                       select new { ProvName = p.ProvName, ProdName = s.ProdName};
            foreach (var item in ANS3)
            {
                Console.WriteLine("{0} поставил {1}", item.ProvName, item.ProdName);
            }
        }
    }
}
