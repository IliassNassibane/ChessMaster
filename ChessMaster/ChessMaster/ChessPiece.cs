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
        public int[] _startPosition;
        public List<CPMovement> _movements;
        public Orientation _orientation;
        public bool _alive;

        public ChessPiece(PieceType piece, int[] position, List<CPMovement> movements, Orientation orientation)
        {
            this._piece = piece;
            this._startPosition = position;
            this._movements = movements;
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
