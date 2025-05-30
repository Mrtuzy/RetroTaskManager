using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.View
{
    internal class Screen
    {

        public List<Block> Blocks { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }

        // coordinate of upper left corner
        public int X { get; set; }
        public int Y { get; set; }

        public Screen(int width, int height, int x = 0, int y = 0)
        {
            this.Height = height;
            this.Width = width;
            this.X = x;
            this.Y = y;
            this.Blocks = new List<Block>();
        }

        public void AddBlock(Block block)
        {
            if (Blocks == null)
            {
                Blocks = new List<Block>();
            }
            Blocks.Add(block);
            block.ParentScreen = this;
        }
        public void RemoveBlock(Block block)
        {

            if (Blocks != null && Blocks.Contains(block))
            {
                Blocks.Remove(block);
                block.ParentScreen = null;
            }
        }
        public void ClearBlocks()
        {
            if (Blocks != null)
            {
                foreach (var block in Blocks)
                {
                    block.ParentScreen = null;
                }
                Blocks.Clear();
            }
        }

        public void AddBlocks(List<Block> blocks)
        {
            if (Blocks == null)
            {
                Blocks = new List<Block>();
            }
            foreach (var block in blocks)
            {
                Blocks.Add(block);
                block.ParentScreen = this;
            }
        }

        public void Display()
        {
            Console.Clear();
            Console.SetCursorPosition(X, Y);
            if (Blocks != null && Blocks.Count > 0)
            {
                foreach (var block in Blocks)
                {
                    block.Display();
                }
            }
            else
            {
                Console.WriteLine("No blocks to display.");
            }
        }

    }
}
