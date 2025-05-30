using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager.View
{
    internal class Block
    {
        public Screen ParentScreen { get; set; }
        public Block ParentBlock { get; set; }
        public Block UpperChild { get; set; }

        public Block LeftChild { get; set; }

        public int Height { get; set; }
        public int Width { get; set; }

        // coardinate of upper left corner
        public int X { get; set; }
        public int Y { get; set; }

        public bool enableBorder { get; set; }

        public Block(int weight, int height, Block upperChild = null, Block leftChild = null, Block parent = null)
        {
            this.ParentScreen = null;
            this.ParentBlock = parent;
            this.UpperChild = upperChild;
            this.LeftChild = leftChild;
            this.Height = height;
            this.Width = weight;
            initializeCoordinates();
        }
        private void initializeCoordinates()
        {
            if (ParentBlock != null)
            {
                X = ParentScreen.X;
                Y = ParentScreen.Y;
            }

            else
            {
                X = 0;
                Y = 0;
            }

            if (UpperChild != null)
            {
                Y += UpperChild.Y + UpperChild.Height;
            }

            if (LeftChild != null)
            {
                X += LeftChild.X + LeftChild.Width;
            }


        }


        public void Display()
        {
            if (enableBorder)
            {
                // Draw top border
                Console.SetCursorPosition(X, Y);
                Console.Write("+" + new string('-', Width - 2) + "+");

                // Draw side borders
                for (int i = 1; i < Height - 1; i++)
                {
                    Console.SetCursorPosition(X, Y + i);
                    Console.Write("|" + new string(' ', Width - 2) + "|");
                }

                // Draw bottom border
                if (Height > 1)
                {
                    Console.SetCursorPosition(X, Y + Height - 1);
                    Console.Write("+" + new string('-', Width - 2) + "+");
                }
            }
        }


    }
}
