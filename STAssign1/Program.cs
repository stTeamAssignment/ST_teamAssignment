using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STAssign1
{
    public class Program
    {
        public static void Main(string[] args)
        {

            Item item = GetObject();
            item.ItemNumber = 1;
            item.Description = "Phone";
            item.Weight = 10;
            item.UnitOfMeasure = Item.Measures.EACH;

            Console.WriteLine(PrintOutItem(item));

            Console.ReadKey();
        }

        public static Item GetObject()
        {
            var item = new Item();
            return item;
        }
        public static string PrintOutItem(Item item)
        {
            string values = "Item Number: " + item.ItemNumber + "\n" + "Description: " + item.Description + "\n" +
                "Unit of Measure: " + item.UnitOfMeasure + "\nWeight: " + item.Weight;
            return values;
        }
    }
}
