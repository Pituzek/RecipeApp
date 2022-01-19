using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RecipeApp.Core
{
    public class InvalidRecipeException : Exception
    {
        public InvalidRecipeException(string reason) : base(reason)
        {

        }
    }
}
