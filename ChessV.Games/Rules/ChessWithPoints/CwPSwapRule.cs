
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

using System.Collections.Generic;

namespace ChessV.Games.Rules
{
	public class CwPSwapRule: Rule
	{
		public CwPSwapRule(PieceType kingType, List<PieceType> swapTypes)
		{
			this.kingType = kingType;
			this.swapTypesDst = swapTypes;
		}

		public override void GenerateSpecialMoves( MoveList list, bool capturesOnly, int ply )
		{
			if( !capturesOnly )
			{
				int king = Board.GetPieceTypeBitboard( Game.CurrentSide, kingType.TypeNumber ).LSB; //this seems to always fail...
				if( !IsSquareAttacked( king, Game.CurrentSide ^ 1 ) )
				{
					foreach(Piece p in Game.GetPieceList(Game.CurrentSide))
					{
						if(swapTypesDst.Contains(p.PieceType))
						{
							list.BeginMoveAdd( MoveType.Swap, king, p.Square );
							Piece kingpiece = list.AddPickup( king );
							Piece otherpiece = list.AddPickup(p.Square);
							list.AddDrop( kingpiece, p.Square);
							list.AddDrop( otherpiece, king );
							list.EndMoveAdd( 0 );
						}
					}
				}
			}
		}

		public override void GetNotesForPieceType( PieceType type, List<string> notes )
		{
			if( type == kingType )
				notes.Add( "swap ability" );
		}

		protected PieceType kingType;
		protected PieceType pawnType;
		protected List<PieceType> swapTypesDst;
		protected List<PieceType> swapTypesSrc;
	}
}
