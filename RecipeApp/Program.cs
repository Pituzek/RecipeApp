using System;
using System.Globalization;
using System.IO;

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
            // 1. Read ingredients from a file (recipe.txt)
            // 2. Validate a file
            // 3. Debugging
            // .\ current directory .\Recipe.txt"
            // ..\ previos directory ..\Recipe.txt"
            string ingredients = ReadAllText(@".\Recipe.txt");

            var standardised = StandariseRecipe(ingredients);
            WriteAllText(@".\Recipe-Converted.txt", standardised);
        }

        static string ReadAllText(string path)
        {
            using (var stream = new StreamReader(path))
            {
                var contents = stream.ReadToEnd();
                return contents;
            }
        }

        static void WriteAllText(string path, string text)
        {
            using (var stream = new StreamWriter(path))
            {
                stream.Write(text);
            }
        }

        static string StandariseRecipe(string recipe)
        {
            string[] words = recipe.Split(' ', '\r', '\n');
            for (int i = 0; i < words.Length; i++)
            {
                try
                {
                    StandardiseCookingUnit(i, words);
                }
                catch (InvalidRecipeException ex)
                {
                    Console.WriteLine($"Skipping word, because: {ex.Message}");
                }
            }

            // String.Join() - combine parts of string into one string
            return String.Join(" ", words);
        }

        static void StandardiseCookingUnit(int i, string[] words)
        {
            string cookingUnit = words[i];
            var multipplier = FindMultiplier(cookingUnit);
            if (multipplier == -1) return;

            var amountText = words[i - 1].Trim();

            var isNumber = double.TryParse(
                amountText,
                NumberStyles.AllowDecimalPoint,
                CultureInfo.InvariantCulture,
                out double amount);

            if (!isNumber)
            {
                throw new InvalidRecipeException($"{amountText} is not a number");
            }

            var amountMl = amount * multipplier;
            words[i] = "ml";
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
