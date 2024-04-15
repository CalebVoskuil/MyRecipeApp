using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRecipeApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyIngredients worker = new MyIngredients();
            worker.Run();
        }
    }
}
