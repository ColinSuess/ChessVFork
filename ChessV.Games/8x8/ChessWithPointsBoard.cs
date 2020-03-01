
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
using System.Collections.Generic;
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
        public Piece src;
        public Piece dst;
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
            Array = "rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR";
            PawnDoubleMove = true;
            EnPassant = false;
            Castling.Value = "None";
            PromotionRule.Value = "Standard";
            //PromotionRule.Value = "Custom";
            PromotionTypes = "QRNB";
        }
        #endregion

        #region AddPieceTypes
        public override void AddPieceTypes()
        {
            base.AddPieceTypes();
            AddChessPieceTypes();
            
            AddPieceType(FastChariot = new FastChariot("Fast Chariot", "I", 500, 500, "FastChariot"));
            AddPieceType(QueenOfDarkness = new QueenofAirAndDarkness("QueenOfAirAndDarkness", "E", 900, 1000));
            AddPieceType(Peasant = new Peasant("Peasant", "X", 100, 125));
            AddPieceType(Sorceress = new Sorceress("Sorceress", "S", 100, 125));
            AddPieceType(Adept = new Adept("Adept", "A", 100, 125));
            if(Array.Contains("O") || Array.Contains("o"))
            {
                AddPieceType(OldQueen = new OldQueen("Old Queen", "O", 950, 1000, "StarCat"));
            }
        }
        #endregion

        #region AddRules
        public override void AddRules()
        {
            base.AddRules();
            if (Array.Contains("O") || Array.Contains("o"))
            {
                RemoveRule(typeof(Rules.CheckmateRule));
                AddRule(new Rules.CwPCheckmateRule(King));
            }
                //AddRule(new Rules.CheckmateRule(King));
                



                //AddRule(new Rules.ChessWithPointsSwapRule(src, dst));
                //AddRule(new Rules.CwP.ComplexPromotionRule());
                //  OptionalPromotionFromAndToLocationDelegate

                if (PromotionRule.Value == "Custom")
            {
                Rules.ComplexPromotionRule promotionRule = new Rules.ComplexPromotionRule();

                List<PieceType> promotionTypes = new List<PieceType>() { Bishop };
                //OR                 List<PieceType> availablePromotionTypes = ParseTypeListFromString(PromotionTypes);


                //Location fromLoc;
                //Location toLoc;
                //Rules.OptionalPromotionFromAndToLocationDelegate x = new Rules.OptionalPromotionFromAndToLocationDelegate(fromLoc, toLoc);
                List<PieceType> promoteByReplacementTypes = new List<PieceType>() { Peasant };
                promotionRule.AddPromotionCapability(Bishop, promotionTypes, promoteByReplacementTypes,
                    (fromLoc, toLoc) => fromLoc.Rank == 3 || toLoc.Rank == 3 ? Rules.PromotionOption.CanPromote : Rules.PromotionOption.CannotPromote);

                //version 1
                //List<PieceType> promoteByReplacementTypes = new List<PieceType>() { FastChariot };
               // promotionRule.AddPromotionCapability(Pawn, promotionTypes, promoteByReplacementTypes, 
                 //   loc => loc.Rank == 7 ? Rules.PromotionOption.MustPromote : Rules.PromotionOption.CannotPromote);

                //v2
                //promotionRule.AddPromotionCapability(Pawn, promotionTypes, null,
                  //  loc => loc.Rank == Board.NumRanks - 1 ? Rules.PromotionOption.MustPromote :
                    //    (loc.Rank >= Board.NumRanks - 3 ? Rules.PromotionOption.CanPromote : Rules.PromotionOption.CannotPromote));

                //v3
                //silverGeneralPromotionRule.AddPromotionCapability(SilverGeneral, promotionTypes, null,
                //(fromLoc, toLoc) => fromLoc.Rank == 7 || toLoc.Rank == 7 ? Rules.PromotionOption.CanPromote : Rules.PromotionOption.CannotPromote);

                AddRule(promotionRule);
            }



            /*

                public void AddPromotionCapability
            (PieceType promotingType,
              List<PieceType> promotionTypes,
              List<PieceType> replacementPromotionTypes,
              OptionalPromotionFromAndToLocationDelegate conditionDeletage)
            {
                PromotionCapability newCapability = new PromotionCapability();
                newCapability.PromotingType = promotingType;
                newCapability.PromotionTypes = promotionTypes;
                newCapability.ReplacementPromotionTypes = replacementPromotionTypes;
                newCapability.ConditionDelegate = null;
                newCapability.FromAndToConditionDelegate = conditionDeletage;
                promotionCapabilities.Add(newCapability);
            }*/
        }

        #endregion
    }
}

