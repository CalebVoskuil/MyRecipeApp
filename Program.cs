using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRecipeApp
{
    /// <summary>
    /// Caleb Voskuil
    /// ST10397320
    /// Prog6221
    /// group 1
    /// References:
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            MyIngredients worker = new MyIngredients();
            while (true)
            {
                Console.WriteLine("1. Enter Recipe Details");
                Console.WriteLine("2. Display Recipe");
                Console.WriteLine("3. Scale Recipe");
                Console.WriteLine("4. Reset");
                Console.WriteLine("5. Exit");

                Console.WriteLine("Enter your choice: ");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch(choice)
                {
                    case 1:
                        worker.EnterRecipeDetails();
                        break;
                    case 2:
                        worker.DisplayRecipe();
                        break;
                    //case 3:
                    //    Console.WriteLine("Enter the scale factor: ");
                    //    float factor = float.Parse(Console.ReadLine());
                    //    worker.ScaleRecipe();
                    //    break;
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
