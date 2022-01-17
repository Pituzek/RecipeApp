using System;
using System.Globalization;

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
        //Cup	          0.24 l
        //Tablespoon      14.79 ml
        //Teaspoon        4.93 ml
        static double[] multipliers = { 240, 14.79, 4.93 };
        static string[] units = { "cup", "tablespoon", "teaspoon" };

        static void Main(string[] args)
        {
            //1.5 cups all-purpose flour. 3.5 teaspoons baking powder. 1 teaspoon salt, or more to taste. 1 tablespoon white sugar. 1.25 cups milk. 1 egg. 3 tablespoons butter, melted

            Console.WriteLine("Please enter the ingredients");
            string ingredients = "1.5 cups all-purpose flour. 3.5 teaspoons baking powder." +
                                " 1 teaspoon salt, or more to taste. 1 tablespoon white sugar." +
                                " 1.25 cups milk. 1 egg. 3 tablespoons butter, melted";
            var standardised = StandariseRecipe(ingredients);
            Console.WriteLine(standardised);
        }

        static string StandariseRecipe(string recipe)
        {
            string[] words = recipe.Split(" ");
            for (int i = 0; i < words.Length; i++)
            {
                StandardiseCookingUnit(i, words);
            }

            // String.Join() - combine parts of string into one string
            return String.Join(" ", words);
        }

        static void StandardiseCookingUnit(int i, string[] words)
        {
            string cookingUnit = words[i];
            //then find the equivalent ml multiplier for that amount
            var multipplier = FindMultiplier(cookingUnit);
            if (multipplier == -1) return;
            //if it is cooking unit, go back 1 word to find the amount
            var amountText = words[i - 1];
            //multiply the amount from multiplier
            var amountMl = double.Parse(amountText, CultureInfo.InvariantCulture) * multipplier;
            //replace the old amount with the new amount
            words[i] = "ml";
            //replace the old unit with the new unit
            words[i - 1] = amountMl.ToString();
        }

        static double FindMultiplier(string cookingUnit)
        {
            for(int i = 0; i < units.Length; i++)
            {
                if (units[i].Equals(cookingUnit, StringComparison.OrdinalIgnoreCase) ||
                   (units[i] + "s").Equals(cookingUnit, StringComparison.OrdinalIgnoreCase))
                {
                    return multipliers[i];
                }
            }

            return -1;
        }
    }
}
