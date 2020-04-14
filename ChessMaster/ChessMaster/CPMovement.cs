using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessMaster.ChessMaster
{
    public class CPMovement
    {
        private int[] _direction { get; }
        private bool _infiniteRange { get; }

        public CPMovement(int[] direction, bool range)
        {
            this._direction = direction;
            this._infiniteRange = range;
        }
    }
}
