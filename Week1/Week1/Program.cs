using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week1
{
    class Program
    {
        static void Main(string[] args)
        {
            #region BasicObject

            int someInt = 34;
            string someString = "Hello World";
            bool someBoolean = true;

            var anotherInt = 22;
            var anotherString = "Good day";
            var anotherBoolean = false;

            Console.WriteLine($"Normal initialization : {someInt}, {someString}, {someBoolean}");
            Console.WriteLine($"Var initialization : {anotherInt}, {anotherString}, {anotherBoolean}");

            #endregion

            #region IfStatement

            var isTrue = false;
            if (isTrue)
            {
                Console.WriteLine($"This statement is true");
            }
            else
            {
                Console.WriteLine($"This statement is false");
            }

            #endregion

            #region ForLoop

            for (var counter = 0; counter < 10; counter++)
            {
                Console.Write($"{counter} ");
            }

            Console.WriteLine();

            var someList = new List<string>()
            {
                "Item 1", "Item 2", "Item 3", "Item 4", "Item 5"
            };
            foreach (var item in someList)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine();

            #endregion

            #region WhileLoop

            var counterTwo = 0;
            while (counterTwo < 10)
            {
                Console.Write($"{counterTwo} ");
                counterTwo++;
            }

            Console.WriteLine();

            counterTwo = 0;
            var exitStatus = true;
            do
            {
                Console.Write($"{counterTwo} ");
                counterTwo++;
                exitStatus = counterTwo >= 10;
            } while (!exitStatus);

            Console.WriteLine();

            #endregion

            #region TryCatch

            var someArray = new int[5] {1, 2, 3, 4, 5};
            try
            {
                Console.WriteLine(someArray[7]);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            #endregion

            #region CollectionType

            var itemList = new List<string>(){"Item1", "Item2", "Item3"};
            var itemDictionary = new Dictionary<string, string>(){{"KeyOne", "ItemOne"}, {"KeyTwo", "ItemTwo"}, {"KeyThree", "ItemThree"}};
            var itemTuple = new Tuple<string, bool, int>("Hello", false, 33);

            foreach (var item in itemList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine();

            foreach (var item in itemDictionary)
            {
                Console.WriteLine($"{item.Key} : {item.Value}");
            }
            Console.WriteLine(itemDictionary["KeyTwo"]);
            Console.WriteLine();

            Console.WriteLine($"Items in tuple : {itemTuple.Item1}, {itemTuple.Item2}, {itemTuple.Item3}");

            #endregion

            Console.ReadKey();
        }
    }
}
