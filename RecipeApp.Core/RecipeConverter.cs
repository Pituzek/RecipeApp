using System;
using System.Globalization;
using System.IO;

namespace RecipeApp.Core
{
    //Cooking Unit:   SI unit:
    //Cup	          0.24 l
    //Gallon          3.79 l
    //Fluid Ounce	  29.57 ml
    //Pint            0.47 l
    //Quart           0.95 l
    //Tablespoon      14.79 ml
    //Teaspoon        4.93 ml

    public class RecipeConverter
    {
        //Cup	          0.24 l
        //Tablespoon      14.79 ml
        //Teaspoon        4.93 ml
        static double[] multipliers = { 240, 14.79, 4.93 };
        static string[] units = { "cup", "tablespoon", "teaspoon" };

        public static string ConvertRecipe(string recipe, bool isSiUnit)
        {
            if (isSiUnit)
            {
                return ConvertToSiUnits(recipe);
            }
            else
            {
                return ConvertToCookingUnits(recipe);
            }
        }

        private static string ConvertToCookingUnits(string recipe)
        {
            string[] words = recipe.Split(' ', '\r', '\n');
            for (int i = 0; i < words.Length; i++)
            {
                try
                {
                    ConvertToCookingUnit(i, words);
                }
                catch (InvalidRecipeException ex)
                {
                    Console.WriteLine($"Skipping word, because: {ex.Message}");
                }
            }

            return String.Join(" ", words);
        }

        private static string ConvertToSiUnits(string recipe)
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

            return String.Join(" ", words);
        }

        static void StandardiseCookingUnit(int i, string[] words)
        {
            string cookingUnit = words[i];
            var multipplier = FindMultiplier(cookingUnit);
            if (multipplier == -1) return;

            var amountText = words[i - 1].Trim();

            var isNumber = ParseDouble(amountText, out var amount);

            if (!isNumber)
            {
                throw new InvalidRecipeException($"{amountText} is not a number");
            }

            var amountMl = amount * multipplier;
            words[i] = "ml";
            words[i - 1] = amountMl.ToString("F2", CultureInfo.InvariantCulture);
        }

        static double FindMultiplier(string cookingUnit)
        {
            for (int i = 0; i < units.Length; i++)
            {
                if (units[i].Equals(cookingUnit, StringComparison.OrdinalIgnoreCase) ||
                   (units[i] + "s").Equals(cookingUnit, StringComparison.OrdinalIgnoreCase))
                {
                    return multipliers[i];
                }
            }

            return -1;
        }

        static void ConvertToCookingUnit(int i, string[] words)
        {
            var ml = GetMl(i, words);
            if (ml == -1) return;

            var cookingUnitIndex = GetCookingUnitIndex(ml);
            var unit = units[cookingUnitIndex];
            var multiplier = multipliers[cookingUnitIndex];
            var convertedAmount = ml / multiplier;

            words[i - 1] = convertedAmount.ToString("F2", CultureInfo.InvariantCulture);
            words[i] = unit;
        }

        static double GetMl(int i, string[] words)
        {
            if (words[i] == "ml")
            {
                var isNumber = ParseDouble(words[i - 1], out var ml);
                if (!isNumber) return -1;
                return ml;
            }
            else
            {
                return -1;
            }
        }

        static int GetCookingUnitIndex(double ml)
        {
            var smallestDifference = double.MaxValue;
            var closestCookingUnitIndex = 2; // 2 is the smallest multiplier from multipliers consts
            for (int i = 0; i < multipliers.Length; i++)
            {
                var multiplier = multipliers[i];
                if (multiplier > ml) continue;

                var difference = ml - multiplier;
                if (difference < smallestDifference)
                {
                    smallestDifference = difference;
                    closestCookingUnitIndex = i;
                }
            }

            return closestCookingUnitIndex;
        }

        private static bool ParseDouble(string amountText, out double amount)
        {
            var isNumber = double.TryParse(
                amountText,
                NumberStyles.AllowDecimalPoint,
                CultureInfo.InvariantCulture,
                out amount);

            return isNumber;
        }
    }
}
