using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRecipeApp
{
    internal class MenuHandler
    {
        private MyIngredients worker = new MyIngredients();
        public void HandleMenu()
        {
            while (true)
            {
                Console.WriteLine("\n1. Enter Recipe Details");
                Console.WriteLine("2. Display Recipe");
                Console.WriteLine("3. Scale Recipe");
                Console.WriteLine("4. Reset");
                Console.WriteLine("5. Exit");

                Console.WriteLine("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("\n");

                switch (choice)
                {
                    case 1:
                        worker.EnterRecipeDetails();
                        break;
                    case 2:
                        worker.DisplayRecipe();
                        break;
                    case 3:
                        Console.WriteLine("Enter the scale factor: ");
                        float factor = float.Parse(Console.ReadLine());
                        worker.ScaleRecipe(factor);
                        break;
                    case 4:
                        worker.Reset();
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice");
                        break;
                }
            }
        }
    }
}
//-----------------------------------------------O________________END_OF_FILE________________O----------------------------------------------//

