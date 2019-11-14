using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STAssign1
{
    class Program
    {
        static void Main(string[] args)
        {
            var item = GetObject();

            Console.WriteLine(GetValues());

            Console.ReadKey();
        }

        public static Item GetObject()
        {
            var item = new Item();
            return item;
        }

        public static string GetValues()
        {
            string UnitofMeasure = "";

            var item = GetObject();
            item.ItemNumber = 1;
            item.Description = "Phone";
            item.Weight = 10;

            foreach (string str in Enum.GetNames(typeof(Item.UnitofMeasure)))
            {
                UnitofMeasure = UnitofMeasure + str + "\n";
            }

            string values = "Item Number: " + item.ItemNumber + "\n" + "Description: " + item.Description + "\n" + 
                "Unit of Measure: " + UnitofMeasure + "Weight: " + item.Weight;
            return values;
        }
    }
}
