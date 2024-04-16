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

