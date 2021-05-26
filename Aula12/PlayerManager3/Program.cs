using System;
using System.Collections.Generic;

namespace PlayerManager3
{
    public class Program
    {
        private static void Main()
        {
            // List of player is our model
            List<Player> list = new List<Player>()
            { new Player("Leonor", 100), new Player("Miguel", 100) };

            // Create controller
            Controller controller = new Controller(list);

            // Create view
            IView view = new UglyView(controller); //, list);

            // Start program
            controller.Run(view);
        }
    }
}
