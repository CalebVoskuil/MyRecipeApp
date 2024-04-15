using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRecipeApp
{
    class MyIngredients
    {
        string recipeName;
        string[] ingredients;
        string[] steps;

        public void EnterRecipeDetails()
        {
            Console.WriteLine("Enter the recipe name: ");
            recipeName = Console.ReadLine();
            Console.WriteLine("Enter number of ingredients: ");
            int numIngredients = Convert.ToInt32(Console.ReadLine());
            ingredients = new string[numIngredients];

            for(int i = 0; i < numIngredients; i++)
            {
                Console.WriteLine("Enter the ingredient name: ");
                string name = Console.ReadLine();

                Console.WriteLine("Enter the quantity: ");
                string quantity = Console.ReadLine();

                Console.WriteLine("Enter the unit of measurement: ");
                string unit = Console.ReadLine();

                ingredients[i] = $"{quantity} {unit} of {name}";
            }
            Console.WriteLine("Enter number of steps: ");
            int numSteps = Convert.ToInt32(Console.ReadLine());
            steps = new string[numSteps];

            for(int i = 0; i < numSteps; i++)
            {
                Console.WriteLine($"Enter step #{i + 1}: ");
                steps[i] = Console.ReadLine();
            }


        }
        public void DisplayRecipe()
        {
            Console.WriteLine("Recipe Details");
            Console.WriteLine($"Recipe Name: {recipeName}");
            Console.WriteLine("Ingredients: ");
            foreach(string ingredient in ingredients)
            {
                Console.WriteLine(ingredient);
            }
            Console.WriteLine("Steps: ");
            for(int i = 0; i < steps.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {steps[i]}");
            }
            

        }

    }
    
        
  
}
