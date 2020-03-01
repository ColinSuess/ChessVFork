using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessV.Games
{
    #region nobles

    #region Queen types
    #region Old Queen
    [PieceType("OldQueen", "Chess with Points")]
	public class OldQueen : PieceType
	{
		public OldQueen(string name, string notation, int midgameValue, int endgameValue, string preferredImageName = null) :
			base("OldQueen", name, notation, midgameValue, endgameValue, preferredImageName)
		{
			AddMoves(this);
		}

		public static new void AddMoves(PieceType type)
		{
			Rook.AddMoves(type);
			Bishop.AddMoves(type);
		}
	}
    #endregion

    #region QueenofDarkness
    [PieceType("QueenofDarkness", "ChessWithPoints")]
    public class QueenofDarkness : PieceType
    {
        public QueenofDarkness(string name, string notation, int midgameValue, int endgameValue, string preferredImageName = null) :
            base("QueenofDarkness", name, notation, midgameValue, endgameValue, preferredImageName)
        {
            AddMoves(this);
        }
    

        public static new void AddMoves(PieceType type)
        {
            type.Slide(new Direction(0, 1));
            type.Slide(new Direction(0, -1));
            type.Slide(new Direction(1, 0));
            type.Slide(new Direction(-1, 0));
            Bishop.AddMoves(type);
        }
    }
    #endregion
    #endregion Queen types


    #region Rook types

    #region DamagedChariot
    [PieceType("DamagedChariot", "ChessWithPoints")]
    public class DamagedChariot : PieceType
    {
        public DamagedChariot(string name, string notation, int midgameValue, int endgameValue, string preferredImageName = null) :
            base("DamagedChariot", name, notation, midgameValue, endgameValue, preferredImageName)
        {
            AddMoves(this);

            #region Customize piece-square-tables for the Rook
            PSTMidgameInSmallCenter = 0;
            PSTMidgameInLargeCenter = 0;
            PSTMidgameSmallCenterAttacks = 2;
            PSTMidgameLargeCenterAttacks = 2;
            PSTMidgameForwardness = 0;
            PSTMidgameGlobalOffset = 0;
            PSTEndgameInSmallCenter = 0;
            PSTEndgameInLargeCenter = 0;
            PSTEndgameSmallCenterAttacks = 0;
            PSTEndgameLargeCenterAttacks = 0;
            PSTEndgameForwardness = 0;
            PSTEndgameGlobalOffset = 0;
            #endregion
        }

        public static new void AddMoves(PieceType type)
        {
            type.Slide(new Direction(0, 1), 2);
            type.Slide(new Direction(0, -1), 2);
            type.Slide(new Direction(1, 0), 2);
            type.Slide(new Direction(-1, 0), 2);
        }
    }
    #endregion

    #region FastChariot
    [PieceType("FastChariot", "ChessWithPoints")]
    public class FastChariot : PieceType
    {
        public FastChariot(string name, string notation, int midgameValue, int endgameValue, string preferredImageName = null) :
            base("FastChariot", name, notation, midgameValue, endgameValue, preferredImageName)
        {
            AddMoves(this);

            #region Customize piece-square-tables for the Rook
            PSTMidgameInSmallCenter = 0;
            PSTMidgameInLargeCenter = 0;
            PSTMidgameSmallCenterAttacks = 2;
            PSTMidgameLargeCenterAttacks = 2;
            PSTMidgameForwardness = 0;
            PSTMidgameGlobalOffset = 0;
            PSTEndgameInSmallCenter = 0;
            PSTEndgameInLargeCenter = 0;
            PSTEndgameSmallCenterAttacks = 0;
            PSTEndgameLargeCenterAttacks = 0;
            PSTEndgameForwardness = 0;
            PSTEndgameGlobalOffset = 0;
            #endregion
        }

        public static new void AddMoves(PieceType type)
        {
            type.Slide(new Direction(0, 1));
            type.Slide(new Direction(0, -1));
            type.Slide(new Direction(1, 0));
            type.Slide(new Direction(-1, 0));
            type.StepMoveOnly(new Direction(0, 2));
            type.StepMoveOnly(new Direction(0, 3));
            type.StepMoveOnly(new Direction(0, 4));
            type.StepMoveOnly(new Direction(0, 5));
            type.StepMoveOnly(new Direction(0, 6));
            type.StepMoveOnly(new Direction(0, 7));
            type.StepMoveOnly(new Direction(0, -2));
            type.StepMoveOnly(new Direction(0, -3));
            type.StepMoveOnly(new Direction(0, -4));
            type.StepMoveOnly(new Direction(0, -5));
            type.StepMoveOnly(new Direction(0, -6));
            type.StepMoveOnly(new Direction(0, -7));
            type.StepMoveOnly(new Direction(2, 0));
            type.StepMoveOnly(new Direction(3, 0));
            type.StepMoveOnly(new Direction(4, 0));
            type.StepMoveOnly(new Direction(5, 0));
            type.StepMoveOnly(new Direction(6, 0));
            type.StepMoveOnly(new Direction(7, 0));
            type.StepMoveOnly(new Direction(-2, 0));
            type.StepMoveOnly(new Direction(-3, 0));
            type.StepMoveOnly(new Direction(-4, 0));
            type.StepMoveOnly(new Direction(-5, 0));
            type.StepMoveOnly(new Direction(-6, 0));
            type.StepMoveOnly(new Direction(-7, 0));
        }
    }
    #endregion
    #endregion rook types


    #region Bishop types

    #region Clergyriders
    [PieceType("Clergyriders", "ChessWithPoints")]
    public class Clergyriders : PieceType
    {
        public Clergyriders(string name, string notation, int midgameValue, int endgameValue, string preferredImageName = null) :
            base("Clergyriders", name, notation, midgameValue, endgameValue, preferredImageName)
        {
            AddMoves(this);
        }

        public static new void AddMoves(PieceType type)
        {
            type.Step(new Direction(2, 2));
            type.Step(new Direction(-2, -2));
            type.Step(new Direction(-2, 2));
            type.Step(new Direction(2, -2));
        }
    }
    #endregion

    #region HighPriest

    [PieceType("HighPriest", "ChessWithPoints")]
    public class HighPriest : PieceType
    {
        public HighPriest(string name, string notation, int midgameValue, int endgameValue, string preferredImageName = null) :
            base("HighPriest", name, notation, midgameValue, endgameValue, preferredImageName)
        {
            AddMoves(this);
        }

        public static new void AddMoves(PieceType type)
        {
            type.Slide(new Direction(1, 1), 3);
            type.Slide(new Direction(1, -1), 3);
            type.Slide(new Direction(-1, 1), 3);
            type.Slide(new Direction(-1, -1), 3);
            type.Step(new Direction(0, 1));
            type.Step(new Direction(0, -1));
        }
    }
    #endregion
    #endregion bishop types

    #region Knight types
    #region Lancerider
    [PieceType("Lancerider", "ChessWithPoints")]
    public class Lancerider : PieceType
    {
        public Lancerider(string name, string notation, int midgameValue, int endgameValue, string preferredImageName = null) :
            base("Lancerider", name, notation, midgameValue, endgameValue, preferredImageName)
        {
            AddMoves(this);

            //	Customize piece-square-tables for the Knight
            PSTMidgameInSmallCenter = 8;
            PSTMidgameInLargeCenter = 5;
            PSTMidgameForwardness = 2;
            PSTMidgameLargeCenterAttacks = 4;
        }

        public static new void AddMoves(PieceType type)
        {
            type.Step(new Direction(3, 0));
            type.Step(new Direction(1, 2));
            type.Step(new Direction(2, 1));
            type.Step(new Direction(2, -1));
            type.Step(new Direction(1, -2));
            type.Step(new Direction(-1, -2));
            type.Step(new Direction(-2, -1));
            type.Step(new Direction(-2, 1));
            type.Step(new Direction(-1, 2));
        }
    }
    #endregion

    #endregion knight types

    #endregion nobles

    #region Commoner types
    #region Squire
    [PieceType("Squire", "ChessWithPoints")]
    public class Squire : PieceType
    {
        public bool isNoble = false;
        public bool isCommoner = true;
        public Squire(string name, string notation, int midgameValue, int endgameValue, string preferredImageName = null) :
            base("Squire", name, notation, midgameValue, endgameValue, preferredImageName)
        {
            IsPawn = true;
            IsSliced = false;
            AddMoves(this);

            //	Customize the piece-square-tables for the Pawn
            PSTMidgameForwardness = 7;
            PSTEndgameForwardness = 10;
            PSTMidgameInSmallCenter = 6;
        }

        public static new void AddMoves(PieceType type)
        {
            type.StepMoveOnly(new Direction(1, 0));
            type.StepCaptureOnly(new Direction(1, 0));
        }

        public override void Initialize(Game game)
        {
            base.Initialize(game);

            //	Set the pawn hash keys, used for the pawn structure hash table.
            //	Every other type has zeros here (assigned by the base class 
            //	implementation of this function.)  This override sets the 
            //	values to non-zero values for the pawn piece type only.
            for (int player = 0; player < game.NumPlayers; player++)
                pawnHashKeyIndex[player] = 256 * (player + 1);
        }
    }
    #endregion
    #endregion Commoner types

    #region BOTH
    #region Wildstallion
    [PieceType("Wildstallion", "ChessWithPoints")]
    public class Wildstallion : PieceType
    {
        public bool isNoble = true;
        public bool isCommoner = true;

        public Wildstallion(string name, string notation, int midgameValue, int endgameValue, string preferredImageName = null) :
            base("Knight", name, notation, midgameValue, endgameValue, preferredImageName)
        {
            AddMoves(this);

            //	Customize piece-square-tables for the Knight
            PSTMidgameInSmallCenter = 8;
            PSTMidgameInLargeCenter = 5;
            PSTMidgameForwardness = 2;
            PSTMidgameLargeCenterAttacks = 4;
        }

        public static new void AddMoves(PieceType type)
        {
            type.Step(new Direction(1, 2));
            type.Step(new Direction(2, 1));
            type.Step(new Direction(2, -1));
            type.Step(new Direction(1, -2));
            type.Step(new Direction(-1, -2));
            type.Step(new Direction(-2, -1));
            type.Step(new Direction(-2, 1));
            type.Step(new Direction(-1, 2));
        }
    }
    #endregion
    #endregion Both
}
