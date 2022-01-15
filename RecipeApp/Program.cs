using System;

namespace RecipeApp
{
    //Cooking Unit:   SI unit:
    //Cup	          0.24 l
    //Gallon          3.79 l
    //Fluid Ounce	  29.57 ml
    //Pint            0.47 l
    //Quart           0.95 l
    //Tablespoon      14.79 ml
    //Teaspoon        4.93 ml

    class Program
    {
        static void Main(string[] args)
        {
            PrintTeaspoonsToMl();
            PrintTablespoonsToMl();

            //We have bootles of 100ml.
            //How many bottles can we fill after the conversion?
        }

        static void PrintTeaspoonsToMl()
        {
            double teaspoons = GetAmountFromConsole("teaspoons");
            double mlOfTeaspoons = TeaspoonsToMl(teaspoons);
            Print(teaspoons, "teaspoons", mlOfTeaspoons);
        }

        static void PrintTablespoonsToMl()
        {
            double tablespoon = GetAmountFromConsole("tablespoon");
            double mlOfTableSpoons = TableSpoonsToMl(tablespoon);
            Print(tablespoon, "tablespoon", mlOfTableSpoons);
        }

        static double GetAmountFromConsole(string unit)
        {
            ///<summary>
            /// Floating point number with double precision
            /// Precision without inaccurancy - use decimal type (use for money 4.93m)
            /// Use float when you don't plan to use math 4.93f
            /// </summary>
            Console.WriteLine($"Please enter {unit} amount: ");
            string amountText = Console.ReadLine();
            double amount = double.Parse(amountText);

            return amount;
        }

        static double TeaspoonsToMl(double teaspoons)
        {
            double ml = teaspoons * 4.93;
            return ml;
        }

        static double TableSpoonsToMl(double teaspoons)
        {
            double tablespoons = teaspoons * 14.79;
            return tablespoons;
        }

        static void Print(double cookingUnitAmount, string cookingUnit, double ml)
        {
            // string convertedDescription = teaspoonsText + " teaspoons = " + ml + " ml";
            // $ - string interpolation
            string convertedDescription = $"{cookingUnitAmount} {cookingUnit} = {ml:F2} ml";
            Console.WriteLine(convertedDescription);
        }
    }
}
