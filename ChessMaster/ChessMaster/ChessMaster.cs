using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChessMaster.ChessMaster;
using ChessMaster.Enum;
using ChessMaster.GameRules;
using ChessMaster.GameRules.CheatChess;
using ChessMaster.GameRules.Classic;

namespace ChessMaster
{
    public class Game
    {
        public GameType _gameType;
        public IRulesSet _ruleset;
        public Board _board;
        public Player _player;
        public Player _opponent;

        public Game(GameType type)
        {
            this._gameType = type;
            this._ruleset = SetRuleSet(this._gameType);
            this._board = this._ruleset.SetUpBoard();
        }

        public void PlayMatch()
        {
            while(this._ruleset.WinConditionMet(this._player, this._opponent))
            {
                // TODO : Speler maakt een zet;
                // 2) Zet wordt geévalueerd;
                
                if(this._ruleset.WinConditionMet(this._player, this._opponent))
                {

                }
            }
        }

        public IRulesSet SetRuleSet(GameType type)
        {
            IRulesSet ruleSet;

            switch (type)
            {
                case GameType.ChessMaster:
                    ruleSet = new CheatChess();
                    break;
                case GameType.Classic:
                    ruleSet = new Classic();
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            return ruleSet;
        }

        public void LoadPlayers()
        {
            _player = new Player("Player", 1, _ruleset.SetUpPlayer());
            _opponent = new Player("Opponent", 2, _ruleset.SetUpPlayer());
        }
    }
}
