using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChessMaster.Enum;

namespace ChessMaster.ChessMaster
{
    public class ChessPiece
    {
        public PieceType _piece;
        public int[,] _movement;
        public Orientation _orientation;
        public bool _alive;

        public ChessPiece(PieceType piece, int[,] movement, Orientation orientation)
        {
            this._piece = piece;
            this._movement = movement;
            this._orientation = orientation;
            this._alive = true;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("The {0} {1}", this._piece.ToString(), 
                this._alive ? "" : "is still on the board on position");

            return sb.ToString();
        }
    }
}
