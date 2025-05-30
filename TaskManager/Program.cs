namespace TaskManager
{

    internal class Program
    {
        static void Main(string[] args)
        {
            
            View.UI ui = new View.UI();
            View.Screen screen = new View.Screen(100, 50);
            View.Block block1 = new View.Block(120,5);
            View.Block block2 = new View.Block(20, 5,block1);
            View.Block block3 = new View.Block(20, 5,block1,block2);
            block1.enableBorder = true;
            block2.enableBorder = true;
            block3.enableBorder = true;
            screen.AddBlock(block1);
            screen.AddBlock(block2);
            screen.AddBlock(block3);
            ui.CurrentScreen = screen;
            ui.DisplayScreen();
            Console.ReadLine();
        }
    }
}
