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
        public PlayerInstance _player;
        public int[,] _movement;
        public Orientation _orientation;
        public bool _alive;

        public ChessPiece(PieceType piece, PlayerInstance player, int[,] movement, Orientation orientation)
        {
            this._piece = piece;
            this._player = player;
            this._movement = movement;
            this._orientation = orientation;
            this._alive = true;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("The {0} of {1} {2}", this._piece.ToString(), this._player._name, 
                this._alive ? "" : "is still on the board on position");

            return sb.ToString();
        }
    }
}
