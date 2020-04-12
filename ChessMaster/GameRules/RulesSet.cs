using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChessMaster.ChessMaster;

namespace ChessMaster.GameRules
{
    public interface IRulesSet
    {
        Board SetUpBoard();

        List<ChessPiece> SetUpPlayer();

        void MoveEvaluation();

        bool WinConditionMet(Player player, Player opponent);
    }
}
