// Colin Suess for UWCE Game Design 2019/2020

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessV.Games
{
    #region nobles

    #region Rook types
    

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
        }
    }
    #endregion

    #region ArmoredChariot
    [PieceType("ArmoredChariot", "ChessWithPoints")]
    public class ArmoredChariot : PieceType
    {
        public ArmoredChariot(string name, string notation, int midgameValue, int endgameValue, string preferredImageName = null) :
            base("ArmoredChariot", name, notation, midgameValue, endgameValue, preferredImageName)
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
            type.Slide(new Direction(0, 1), 4);
            type.Slide(new Direction(0, -1), 4);
            type.Slide(new Direction(1, 0), 4);
            type.Slide(new Direction(-1, 0), 4);
        }
    }
    #endregion

    #region ArcaneTower
    [PieceType("ArcaneTower", "ChessWithPoints")]
    public class ArcaneTower : PieceType
    {
        public ArcaneTower(string name, string notation, int midgameValue, int endgameValue, string preferredImageName = null) :
            base("ArcaneTower", name, notation, midgameValue, endgameValue, preferredImageName)
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
            type.Step(new Direction(0, 1));
            type.Step(new Direction(0, -1));
            type.Step(new Direction(1, 0));
            type.Step(new Direction(-1, 0));
        }
    }
    #endregion

    #endregion



    #region Corruptedabbot
    [PieceType("Corruptedabbot", "ChessWithPoints")]
    public class Corruptedabbot : PieceType
    {
        public Corruptedabbot(string name, string notation, int midgameValue, int endgameValue, string preferredImageName = null) :
            base("Corruptedabbot", name, notation, midgameValue, endgameValue, preferredImageName)
        {
            AddMoves(this);
        }

        public static new void AddMoves(PieceType type)
        {
            type.Slide(new Direction(1, 1));
            type.Slide(new Direction(1, -1));
            type.Slide(new Direction(-1, 1));
            type.Slide(new Direction(-1, -1));
        }
    }
    #endregion

    #region Arcanepriest
    [PieceType("Arcanepriest", "ChessWithPoints")]
    public class Arcanepriest : PieceType
    {
        public Arcanepriest(string name, string notation, int midgameValue, int endgameValue, string preferredImageName = null) :
            base("Arcanepriest", name, notation, midgameValue, endgameValue, preferredImageName)
        {
            AddMoves(this);
        }

        public static new void AddMoves(PieceType type)
        {
            type.Slide(new Direction(1, 1), 3);
            type.Slide(new Direction(1, -1), 3);
            type.Slide(new Direction(-1, 1), 3);
            type.Slide(new Direction(-1, -1), 3);
        }
    }
    #endregion

		

    #endregion

    #region Queen types
    #region Sorceress
    [PieceType("Sorceress", "ChessWithPoints")]
    public class Sorceress : PieceType
    {
        public Sorceress(string name, string notation, int midgameValue, int endgameValue, string preferredImageName = null) :
            base("Sorceress", name, notation, midgameValue, endgameValue, preferredImageName)
        {
            AddMoves(this);
        }

        public static new void AddMoves(PieceType type)
        {
            //Rook
            type.Slide(new Direction(0, 1), 5);
            type.Slide(new Direction(0, -1), 5);
            type.Slide(new Direction(1, 0), 5);
            type.Slide(new Direction(-1, 0), 5);
            //Bishop
            type.Slide(new Direction(1, 1),5);
            type.Slide(new Direction(1, -1),5);
            type.Slide(new Direction(-1, 1),5);
            type.Slide(new Direction(-1, -1),5);
        }
    }
    #endregion

    #region JoanofArc
    [PieceType("JoanofArc", "ChessWithPoints")]
    public class JoanofArc : PieceType
    {
        public JoanofArc(string name, string notation, int midgameValue, int endgameValue, string preferredImageName = null) :
            base("JoanofArc", name, notation, midgameValue, endgameValue, preferredImageName)
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

    #region QueenofAir
    [PieceType("QueenofAir", "ChessWithPoints")]
    public class QueenofAir : PieceType
    {
        public QueenofAir(string name, string notation, int midgameValue, int endgameValue, string preferredImageName = null) :
            base("QueenofAir", name, notation, midgameValue, endgameValue, preferredImageName)
        {
            AddMoves(this);
        }

        public static new void AddMoves(PieceType type)
        {
            //Rook.AddMoves(type);
            type.Slide(new Direction(0, 2));
            type.Slide(new Direction(0, -2));
            type.Slide(new Direction(2, 0));
            type.Slide(new Direction(-2, 0));
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
            type.Slide(new Direction(0, 2));
            type.Slide(new Direction(0, -2));
            type.Slide(new Direction(2, 0));
            type.Slide(new Direction(-2, 0));
            Bishop.AddMoves(type);
        }
    }
    #endregion


    #endregion

    #endregion

    #region Knight types

    #region Mule
    [PieceType("Mule", "ChessWithPoints")]
    public class Mule : PieceType
    {
        public Mule(string name, string notation, int midgameValue, int endgameValue, string preferredImageName = null) :
            base("Mule", name, notation, midgameValue, endgameValue, preferredImageName)
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

    #region Pegasus
    [PieceType("Pegasus", "ChessWithPoints")]
    public class Pegasus : PieceType
    {
        public Pegasus(string name, string notation, int midgameValue, int endgameValue, string preferredImageName = null) :
            base("Pegasus", name, notation, midgameValue, endgameValue, preferredImageName)
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

    #endregion    

    

    #endregion

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
            //type.StepCaptureOnly(new Direction(1, 1));
            //type.StepCaptureOnly(new Direction(1, -1));
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

    #region Shieldbearer
    [PieceType("Shieldbearer", "ChessWithPoints")]
    public class Shieldbearer : PieceType
    {
        public bool isNoble = false;
        public bool isCommoner = true;
        public Shieldbearer(string name, string notation, int midgameValue, int endgameValue, string preferredImageName = null) :
               base("Pawn", name, notation, midgameValue, endgameValue, preferredImageName)
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
            type.StepCaptureOnly(new Direction(1, 1));
            type.StepCaptureOnly(new Direction(1, -1));
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

    #region Peasant
    [PieceType("Peasant", "ChessWithPoints")]
    public class Peasant : PieceType
    {
        public bool isNoble = false;
        public bool isCommoner = true;
        public Peasant(string name, string notation, int midgameValue, int endgameValue, string preferredImageName = null) :
              base("Pawn", name, notation, midgameValue, endgameValue, preferredImageName)
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
            type.StepCaptureOnly(new Direction(1, 1));
            type.StepCaptureOnly(new Direction(1, -1));
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

    #region Adept
    [PieceType("Adept", "ChessWithPoints")]
    public class Adept : PieceType
    {
        public bool isNoble = false;
        public bool isCommoner = true;
        public Adept(string name, string notation, int midgameValue, int endgameValue, string preferredImageName = null) :
               base("Pawn", name, notation, midgameValue, endgameValue, preferredImageName)
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
            //type.StepCaptureOnly(new Direction(1, 1));
            //type.StepCaptureOnly(new Direction(1, -1));
            
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


    #endregion

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

    #endregion
}
