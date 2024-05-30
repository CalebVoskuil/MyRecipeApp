using Hangfire.Server;
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
    /// References:https://youtu.be/GhQdlIFylQ8?si=cKIYSWunHDC1csWj
    /// https://youtu.be/gfkTfcpWqAY?si=3BredEtmLRK-IVXr
    /// https://youtu.be/wxznTygnRfQ?si=YdSPdyKekHStCUFz
    /// Repository link : https://github.com/CalebVoskuil/MyRecipeApp.git
    /// </summary>
    internal class Program
    {
        static void Main(string[] args)
        {
            
            MenuHandler menu = new MenuHandler();
            menu.HandleMenu();

        }

    }
}
//-----------------------------------------------O________________END_OF_FILE________________O----------------------------------------------//
