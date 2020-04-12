using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChessMaster.ChessMaster;

namespace ChessMaster.GameRules.CheatChess
{
    public partial class CheatChess : IRulesSet
    {
        public Board SetUpBoard()
        {
            Board board = new Board();

            board._grid = new GridCell[8,8];

            return board;
        }

        public List<ChessPiece> SetUpPlayer(Player player)
        {
            List<ChessPiece> pieces = new List<ChessPiece>();

            return pieces;
        }
    }
}
