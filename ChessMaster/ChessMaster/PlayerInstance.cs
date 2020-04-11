using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessMaster.ChessMaster
{
    public class PlayerInstance
    {
        public string _name;
        public int _playerID;
        public List<ChessPiece> _pieces;

        public PlayerInstance(string name, int id)
        {
            this._name = name;
            this._playerID = id;
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendFormat("Player {0}({1}):\n", this._name, this._playerID);

            foreach (ChessPiece piece in this._pieces)
            {
                sb.AppendFormat("{0}\n", piece.ToString());
            }

            return sb.ToString();
        }
    }
}
