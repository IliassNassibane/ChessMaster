using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessMaster.ChessMaster
{
    public class Board
    {
        public GridCell[,] _grid;

        public void Display()
        {
            for (int i = 0; i < 8; i++)
            {
                string sequence = "";

                for (int j = 0; j < 8; j++)
                {
                    sequence += "[ ] ";
                }

                // TODO : Hierop doorborduren, zodat de assets geladen kunnen worden; 
            }
        }
    }
}
