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
            Player player_1;
            Player player_2;

            if (CoinToss() == 1)
            {
                player_1 = this._player;
                player_2 = this._opponent;
            } else
            {
                player_2 = this._player;
                player_1 = this._opponent;
            }

            while (this._ruleset.WinConditionMet(player_1) || this._ruleset.WinConditionMet(player_2))
            {
                // TODO : 1) Speler maakt een zet;
                // 2) Zet wordt geévalueerd;
                // 3) Volgende speler...;
                this._ruleset.MoveEvaluation();
                
                if(this._ruleset.WinConditionMet(this._player))
                {
                    continue;
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

        public int CoinToss()
        {
            Random coin = new Random();

            return coin.Next(1, 3);
        }
    }
}
