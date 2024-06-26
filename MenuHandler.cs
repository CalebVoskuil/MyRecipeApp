﻿
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRecipeApp
{
    internal class MenuHandler
    {
         MyIngredients worker = new MyIngredients();
        
        public void HandleMenu()
        {
            worker.OnCaloriesExceeded += HandleCaloriesExceeded;

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
                        worker.DisplayAllRecipes();
                        break;
                    case 3:
                        Console.WriteLine("Enter the recipe name to scale: ");
                        string recipeName = Console.ReadLine();
                        Console.WriteLine("Enter the scale factor: ");
                        //checks to make sure factor is a postive number and above 0 before doing the calculation
                        float factor;
                        while (!float.TryParse(Console.ReadLine(), out factor) || factor <= 0)
                        {
                            Console.WriteLine("Invalid input. Enter a positive number for scaling factor: ");
                        }
                        worker.ScaleRecipe(recipeName, factor);
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
        private void HandleCaloriesExceeded(string message)
        {
            ConsoleColor originalColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ForegroundColor = originalColor;
            
        }
    }
}
//-----------------------------------------------O________________END_OF_FILE________________O----------------------------------------------//

