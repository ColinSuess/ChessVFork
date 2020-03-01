
/***************************************************************************

                                 ChessV

                  COPYRIGHT (C) 2012-2019 BY GREG STRONG

This file is part of ChessV.  ChessV is free software; you can redistribute
it and/or modify it under the terms of the GNU General Public License as 
published by the Free Software Foundation, either version 3 of the License, 
or (at your option) any later version.

ChessV is distributed in the hope that it will be useful, but WITHOUT ANY 
WARRANTY; without even the implied warranty of MERCHANTABILITY or 
FITNESS FOR A PARTICULAR PURPOSE.  See the GNU General Public License for 
more details; the file 'COPYING' contains the License text, but if for
some reason you need a copy, please visit <http://www.gnu.org/licenses/>.

****************************************************************************/
using ChessV.Evaluations;
namespace ChessV.Games
{
    //**********************************************************************
    //
    //                              Chess
    //
    //    This class implements the classic game of Chess.  Most of the 
    //    functionality, however, are in the generic game classes from 
    //    which it is derived as they are intended to provide functionality
    //    common to chess variants.

    [Game("Chess with Points", typeof(Geometry.Rectangular), 8, 8,
          XBoardName = "normal",
          InventedBy = "UWCE",
          Invented = "circa 21th century",
          Tags = "Chess Variant",
          GameDescription1 = "Exact origins unknown",
          GameDescription2 = "Seattle area")]
    [Appearance(ColorScheme = "Luna Decorabat")]
    public class ChessWithPoints : Abstract.Generic8x8
    {
        public PieceType Squire;
        public PieceType ShieldBearer;
        public PieceType Peasant;
        public PieceType Adept;
        public PieceType Mule;
        public PieceType WildStallion;
        public PieceType ClergyRiders;
        public PieceType LanceRider;
        public PieceType Pegasus;
        public PieceType HighPriest;
        public PieceType CorruptedAbbot;
        public PieceType ArcanePriest;
        public PieceType DamagedChariot;
        public PieceType FastChariot;
        public PieceType ArmoredChariot;
        public PieceType ArcaneTower;
        public PieceType Sorceress;
        public PieceType JoanofArc;
        public PieceType QueenOfAir;
        public PieceType QueenOfDarkness;
        [Royal] public PieceType OldQueen;
        
        // *** CONSTRUCTION *** //

        public ChessWithPoints() :
            base
                ( /* symmetry = */ new MirrorSymmetry())
        {

        }


        // *** INITIALIZATION *** //

        #region SetGameVariables
        public override void SetGameVariables()
        {
            base.SetGameVariables();
            Array = "rneokbnr/pppppppp/8/8/8/8/XXXXXXXX/INEOKBNI";
            PawnDoubleMove = true;
            EnPassant = false;
            Castling.Value = "None";
            PromotionRule.Value = "Standard";
            PromotionTypes = "QRNB";
        }
        #endregion

        #region AddPieceTypes
        public override void AddPieceTypes()
        {
            base.AddPieceTypes();
            AddChessPieceTypes();
            AddPieceType(OldQueen = new OldQueen("Old Queen", "O", 950, 1000, "StarCat"));
            AddPieceType(FastChariot = new FastChariot("Fast Chariot", "I", 500, 500, "FastChariot"));
            AddPieceType(QueenOfDarkness = new QueenofAirAndDarkness("QueenOfAirAndDarkness", "E", 900, 1000));
            AddPieceType(Peasant = new Peasant("Peasant", "X", 100, 125));
        }
        #endregion
        

        #region AddRules
        public override void AddRules()
        {
            base.AddRules();
            AddRule(new Rules.CwPCheckmateRule(OldQueen));
        }

        #endregion
    }
}
