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

        public List<ChessPiece> SetUpPlayer()
        {
            List<ChessPiece> pieces = new List<ChessPiece>();

            for (int i = 0; i < 9; i++)
            {
                List<CPMovement> pawnMovements = new List<CPMovement>();
                pawnMovements.Add(new CPMovement(new int[] { 0, 1 }, false));

                pieces.Add(new ChessPiece(Enum.PieceType.Pawn, new int[] { 1, i }, pawnMovements, Enum.Orientation.Straight));
            }

            List<CPMovement> rookMovements = new List<CPMovement>
            {
                new CPMovement(new int[] { 0, 1 }, true),
                new CPMovement(new int[] { 0, -1 }, true),
                new CPMovement(new int[] { 1, 0 }, true),
                new CPMovement(new int[] { -1, 0 }, true)
            };

            pieces.Add(new ChessPiece(Enum.PieceType.Rook, new int[] { 0, 0 }, rookMovements, Enum.Orientation.Omni));
            pieces.Add(new ChessPiece(Enum.PieceType.Rook, new int[] { 0, 7 }, rookMovements, Enum.Orientation.Omni));

            List<CPMovement> knightMovements = new List<CPMovement>
            {
                new CPMovement(new int[] { 1, 2 }, false),
                new CPMovement(new int[] { -1, 2 }, false),
                new CPMovement(new int[] { 1, -2 }, false),
                new CPMovement(new int[] { -1, -2 }, false),
                new CPMovement(new int[] { 2, 1 }, false),
                new CPMovement(new int[] { -2, 1 }, false),
                new CPMovement(new int[] { 2, -1 }, false),
                new CPMovement(new int[] { -2, -1 }, false)
            };

            pieces.Add(new ChessPiece(Enum.PieceType.Knight, new int[] { 0, 1 }, knightMovements, Enum.Orientation.Omni));
            pieces.Add(new ChessPiece(Enum.PieceType.Knight, new int[] { 0, 6 }, knightMovements, Enum.Orientation.Omni));

            List<CPMovement> bishopMovements = new List<CPMovement>
            {
                new CPMovement(new int[] { 1, -1 }, true),
                new CPMovement(new int[] { -1, 1 }, true),
                new CPMovement(new int[] { 1, 1 }, true),
                new CPMovement(new int[] { -1, -1 }, true)
            };

            pieces.Add(new ChessPiece(Enum.PieceType.Bishop, new int[] { 0, 2 }, bishopMovements, Enum.Orientation.Straight));
            pieces.Add(new ChessPiece(Enum.PieceType.Bishop, new int[] { 0, 5 }, bishopMovements, Enum.Orientation.Straight));

            List<CPMovement> kingMovements = new List<CPMovement>
            {
                new CPMovement(new int[] { 1, -1 }, false),
                new CPMovement(new int[] { -1, 1 }, false),
                new CPMovement(new int[] { 1, 1 }, false),
                new CPMovement(new int[] { -1, -1 }, false),
                new CPMovement(new int[] { 0, 1 }, false),
                new CPMovement(new int[] { 0, -1 }, false),
                new CPMovement(new int[] { 1, 0 }, false),
                new CPMovement(new int[] { -1, 0 }, false)
            };

            pieces.Add(new ChessPiece(Enum.PieceType.King, new int[] { 0, 3 }, kingMovements, Enum.Orientation.Straight));

            List<CPMovement> queenMovements = new List<CPMovement>
            {
                new CPMovement(new int[] { 1, -1 }, true),
                new CPMovement(new int[] { -1, 1 }, true),
                new CPMovement(new int[] { 1, 1 }, true),
                new CPMovement(new int[] { -1, -1 }, true),
                new CPMovement(new int[] { 0, 1 }, true),
                new CPMovement(new int[] { 0, -1 }, true),
                new CPMovement(new int[] { 1, 0 }, true),
                new CPMovement(new int[] { -1, 0 }, true)
            };
            
            pieces.Add(new ChessPiece(Enum.PieceType.Queen, new int[] { 0, 4 }, queenMovements, Enum.Orientation.Straight));            

            return pieces;
        }
    }
}
