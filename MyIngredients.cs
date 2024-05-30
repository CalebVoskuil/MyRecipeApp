using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyRecipeApp
{
   public class Ingredient
    {
        public string Name { get; set; }
        public float Quantity { get; set; }
        public string Unit { get; set; }
        public int Calories { get; set; }
        public string FoodGroup { get; set; }

        public override string ToString()
        {
            return $"{Quantity} {Unit} of {Name} ({Calories} calories, {FoodGroup})";
        }
        //------------------------------------------------------------------------------------------------------------------------------------------------------------//
        public void ConvertUnits(float factor)
        {
            // Define conversion ratios for common unit conversions
            var unitConversions = new Dictionary<string, Dictionary<string, float>>
    {
        { "teaspoon", new Dictionary<string, float> { { "tablespoon", 1.0f / 3 }, { "cup", 1.0f / 48 }, { "ounce", 1.0f / 6 }, { "gram", 5 } } },
        { "tablespoon", new Dictionary<string, float> { { "teaspoon", 3 }, { "cup", 1.0f / 16 }, { "ounce", 1.0f / 2 }, { "gram", 15 } } },
        { "cup", new Dictionary<string, float> { { "teaspoon", 48 }, { "tablespoon", 16 }, { "ounce", 8 }, { "gram", 240 } } },
        { "ounce", new Dictionary<string, float> { { "teaspoon", 6 }, { "tablespoon", 2 }, { "cup", 1.0f / 8 }, { "gram", 28.35f } } },
        { "gram", new Dictionary<string, float> { { "teaspoon", 0.2f }, { "tablespoon", 0.067f }, { "cup", 0.0042f }, { "ounce", 0.035f } } }
        // Add more conversion ratios as needed
    };

            // Check if the current unit has conversion ratios defined
            if (unitConversions.ContainsKey(Unit))
            {
                // Loop through each possible target unit
                foreach (var targetUnit in unitConversions[Unit])
                {
                    // Check if the target unit has a conversion ratio defined
                    if (unitConversions.ContainsKey(targetUnit.Key))
                    {
                        // Calculate the conversion factor from the current unit to the target unit
                        float conversionFactor = unitConversions[Unit][targetUnit.Key];

                        // Convert the quantity to the target unit and scale the quantity
                        float scaledQuantity = Quantity * conversionFactor * factor;

                        // Set the unit to the target unit
                        Unit = targetUnit.Key;
                        Quantity = scaledQuantity;
                        return; // Exit after the first conversion is applied
                    }
                }
                Console.WriteLine($"Conversion to any other unit not supported for unit '{Unit}'.");
            }
            else
            {
                Console.WriteLine($"Unit '{Unit}' not supported for conversion.");
            }
        }
    }
    //------------------------------------------------------------------------------------------------------------------------------------------------------------//
   public class Recipe
    {
        public string Name { get; set; }
        public List<Ingredient> Ingredients { get; set; }
        public List<string> Steps { get; set; }

        public Recipe()
        {
            Ingredients = new List<Ingredient>();
            Steps = new List<string>();
        }

        public int TotalCalories()
        {
            return Ingredients.Sum(ingredient => ingredient.Calories);
        }

        public override string ToString()
        {
            return Name;
        }
    }
 //------------------------------------------------------------------------------------------------------------------------------------------------------------//
   public class MyIngredients
    {
        public delegate void CalorieNotification(string message);
        public event CalorieNotification OnCaloriesExceeded;

        public List<Recipe> recipes = new List<Recipe>();

        public void EnterRecipeDetails()
        {
            Recipe recipe = new Recipe();

            Console.WriteLine("Enter the recipe name: ");
            recipe.Name = Console.ReadLine();

            int numIngredients;
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter number of ingredients: ");
                    numIngredients = int.Parse(Console.ReadLine());
                    if (numIngredients <= 0)
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

            for (int i = 0; i < numIngredients; i++)
            {
                Ingredient ingredient = new Ingredient();

                Console.WriteLine("Enter the ingredient name: ");
                ingredient.Name = Console.ReadLine();

                while (true)
                {
                    try
                    {
                        Console.WriteLine("Enter the quantity: ");
                        ingredient.Quantity = float.Parse(Console.ReadLine());
                        if (ingredient.Quantity <= 0)
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
                ingredient.Unit = Console.ReadLine();

                while (true)
                {
                    try
                    {
                        Console.WriteLine("Enter the number of calories: ");
                        ingredient.Calories = int.Parse(Console.ReadLine());
                        if (ingredient.Calories < 0)
                        {
                            throw new ArgumentOutOfRangeException("Invalid input. Please enter a non-negative number.");
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

                Console.WriteLine("Enter the food group: ");
                ingredient.FoodGroup = Console.ReadLine();

                recipe.Ingredients.Add(ingredient);
            }

            int numSteps;
            while (true)
            {
                try
                {
                    Console.WriteLine("Enter number of steps: ");
                    numSteps = int.Parse(Console.ReadLine());
                    if (numSteps <= 0)
                    {
                        throw new ArgumentOutOfRangeException("Invalid input. Please enter a number above 0: ");
                    }
                    break;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid input. Please input a valid number.");
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            for (int i = 0; i < numSteps; i++)
            {
                Console.WriteLine($"Enter step #{i + 1}: ");
                recipe.Steps.Add(Console.ReadLine());
            }

            recipes.Add(recipe);

            int totalCalories = recipe.TotalCalories();
            Console.WriteLine("*************************************************************************");
            Console.WriteLine($"Total Calories: {totalCalories}");
            if (totalCalories > 300)
            {
                OnCaloriesExceeded?.Invoke("Warning: This recipe exceeds 300 calories!");
            }
            Console.WriteLine("*************************************************************************");
            OnCaloriesExceeded += HandleCaloriesExceeded;
        }
        //------------------------------------------------------------------------------------------------------------------------------------------------------------//
        private void HandleCaloriesExceeded(string message)
        {
            ConsoleColor originalColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ForegroundColor = originalColor;
        }
        //------------------------------------------------------------------------------------------------------------------------------------------------------------//
        public void DisplayAllRecipes()
        {
            var sortedRecipes = recipes.OrderBy(r => r.Name).ToList();
            Console.WriteLine("Recipes List:");
            for (int i = 0; i < sortedRecipes.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {sortedRecipes[i].Name}");
            }

            Console.WriteLine("Enter the number of the recipe you want to view: ");
            int choice = int.Parse(Console.ReadLine());

            if (choice > 0 && choice <= sortedRecipes.Count)
            {
                DisplayRecipe(sortedRecipes[choice - 1]);
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }
        }
        //------------------------------------------------------------------------------------------------------------------------------------------------------------//
        public void DisplayRecipe(Recipe recipe, float factor = 1.0f)
        {
            Console.WriteLine("*************************************************************************");
            Console.WriteLine($"Recipe Name: {recipe.Name}");
            Console.WriteLine("Ingredients: ");
            foreach (var ingredient in recipe.Ingredients)
            {
                Console.WriteLine(ingredient);
            }
            Console.WriteLine("Steps: ");
            for (int i = 0; i < recipe.Steps.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {recipe.Steps[i]}");
            }
            Console.WriteLine("*************************************************************************");
        }
        //------------------------------------------------------------------------------------------------------------------------------------------------------------//
        public void Reset()
        {
            recipes.Clear();
            Console.WriteLine("All recipes have been reset");
        }

        public void ScaleRecipe(string recipeName, float factor)
        {
            var recipe = recipes.FirstOrDefault(r => r.Name.Equals(recipeName, StringComparison.OrdinalIgnoreCase));
            if (recipe == null)
            {
                Console.WriteLine("Recipe not found.");
                return;
            }

            // Scale each ingredient quantity
            foreach (var ingredient in recipe.Ingredients)
            {
                // Convert units to tablespoons and scale the quantity
                ingredient.ConvertUnits(factor);
            }

            // Display the scaled recipe
            DisplayRecipe(recipe, factor);
        }
    }
}
//-----------------------------------------------O________________END_OF_FILE________________O----------------------------------------------//
