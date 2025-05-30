using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.View
{
    internal class UI
    {
        public Screen CurrentScreen { get; set; }
        public UI() { }

        public void DisplayScreen()
        {
            CurrentScreen.Display();
        }


    }

    
}
