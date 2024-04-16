using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRecipeApp
{
    class MyIngredients
    {
        string recipeName;
        string[] Scaled;
        string[] ingredients;
        string[] steps;

        //takes user input for recipe details and stores it in array called ingredients
        public void EnterRecipeDetails()
        {
            Console.WriteLine("Enter the recipe name: ");
            recipeName = Console.ReadLine();
            
            int myIngredients;
             while (true)
            {
                try
                {
                    Console.WriteLine("Enter number of ingredients: ");
                    myIngredients = int.Parse(Console.ReadLine());
                    if (myIngredients <= 0)
                    {
                        throw new ArgumentOutOfRangeException("Invalid input. Please enter a number greater than 0");
                    }  
                        break;   
                }

                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
             ingredients = new string[myIngredients];

            

            //loops to take user input for each ingredient
            for(int i = 0; i < myIngredients; i++)
            {
                Console.WriteLine("Enter the ingredient name: ");
                string name = Console.ReadLine();

                string quantity;
                while(true)
                {
                    try
                    {
                        Console.WriteLine("Enter the quantity: ");
                        quantity = Console.ReadLine();
                        if(float.Parse(quantity) <= 0)
                        {
                            throw new ArgumentOutOfRangeException("Invalid input. Please enter a number greater than 0");                         
                        }
                        break;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                    }
                    catch (ArgumentOutOfRangeException ex)
                    {
                        Console.WriteLine(ex.Message);
                    }
                }

                Console.WriteLine("Enter the unit of measurement: ");
                string unit = Console.ReadLine();
                Console.WriteLine("\n");

                ingredients[i] = $"{quantity} {unit} of {name}";
            }
            

            int mySteps; 
            while(true)
            {
                try
                {
                    Console.WriteLine("Enter number of steps: ");
                    mySteps = int.Parse(Console.ReadLine());
                    if(mySteps <= 0)
                    {
                        throw new ArgumentOutOfRangeException("Invalid input. Please enter a number above 0: ");
                    }
                    break;
                    
                }
                catch(FormatException) 
                {
                    Console.WriteLine("invalid input. PLease input a valid number");
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine(ex.Message);
                }

            }
            steps = new string[mySteps];    

            //loops to take a description of each step
            for(int i = 0; i < mySteps; i++)
            {
                Console.WriteLine($"Enter step #{i + 1}: ");
                steps[i] = Console.ReadLine();
            }


        }
  //----------------------------------------------------------------------------------------------------------------------------------//
        //prints out each ingredient in the ingredients array and each step in the steps array
        public void DisplayRecipe()
        {
            Console.WriteLine("*************************************************************************");
            Console.WriteLine("Recipe Details");
            Console.WriteLine($"Recipe Name: {recipeName}");
            Console.WriteLine("Ingredients: ");
            foreach(string ingredient in ingredients)
            {
                Console.WriteLine(ingredient,"\n");
            }
            Console.WriteLine("Steps: ");
            for(int i = 0; i < steps.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {steps[i]}");
            }
            Console.WriteLine("*************************************************************************");

        }
//----------------------------------------------------------------------------------------------------------------------------------//
        //sets all array values back to empty 
        public void Reset()
        { 
            Scaled = null;
            Console.WriteLine("Recipe details have been reset");
        }
  //----------------------------------------------------------------------------------------------------------------------------------//
        public void ScaleRecipe(float factor)
        {
            for(int i = 0; i < ingredients.Length; i++)
            {
  // splits the string in the ingredients array into an array of strings and stores it in Scaled which is then used to calculate the new quantity
                Scaled = ingredients[i].Split(' ');
                try
                {
                    if(Scaled.Length > 4 || 4 > Scaled.Length)
                    {
                        throw new ArgumentOutOfRangeException("Invalid ingredients.");
                    }
                    if (!float.TryParse(Scaled[0], out float quantity))
                    {
                        Console.WriteLine("Invalid quantity");
                    }
                    quantity *= factor;
                    Console.WriteLine("*************************************************************************");
                    Console.WriteLine("Scaled Recipe: ");
                    Console.WriteLine($"{quantity} {Scaled[1]} of {Scaled[3]}");
                }
                catch (FormatException ex)
                {
                    Console.WriteLine(ex.Message + " Ingredient: " + ingredients);
                }
            }
                
               
                
            Console.WriteLine("Steps: ");
            for (int i = 0; i < steps.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {steps[i]}");
            }
            Console.WriteLine("*************************************************************************"); 
   

        }

    }
}
//-----------------------------------------------O________________END_OF_FILE________________O----------------------------------------------//
