
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
	public class CwPChessWithPointsSwapRule : Rule
	{
		public CwPChessWithPointsSwapRule(Piece srcPiece, Piece dstPiece)
		{
			this.srcPiece = srcPiece;
			this.dstPiece = dstPiece;

		}

		public override void GenerateSpecialMoves(MoveList list, bool capturesOnly, int ply)
		{
			//get location of srcPiece
			//get location of dstPiece
			//swap them

			list.BeginMoveAdd(MoveType.Swap, srcPiece.Square, dstPiece.Square);
			Piece src = list.AddPickup(srcPiece.Square);
			Piece dst = list.AddPickup(dstPiece.Square);
			list.AddDrop(src, dstPiece.Square);
			list.AddDrop(dst, srcPiece.Square);
			list.EndMoveAdd(0);

		}

			/*



		public override void GenerateSpecialMoves( MoveList list, bool capturesOnly, int ply )
		{
			if( !capturesOnly )
			{
				int srcPieceLoc = Board.GetPieceTypeBitboard( Game.CurrentSide, srcPiece.TypeNumber ).LSB;
				int dstPieceLoc = Board.GetPieceTypeBitboard(Game.CurrentSide, dstPiece.TypeNumber).LSB;

				if ( !IsSquareAttacked(srcPieceLoc, Game.CurrentSide ^ 1 ) )
				{
					for( int dir = 0; dir < 8; dir++ )
					{
						int nextSquare = Board.NextSquare( dir, srcPieceLoc);
						if( nextSquare >= 0 && Board[nextSquare] != null &&
							Board[nextSquare].Player == Game.CurrentSide &&
							Board[nextSquare].PieceType != dstPiece)
						{
							//	The king can swap with this piece.  We won't bother 
							//	to see if the target square is attacked because the 
							//	CheckmateRule is going to verify that anyway and we 
							//	don't want to perform that operation twice.
							list.BeginMoveAdd( MoveType.Swap, srcPieceLoc, nextSquare );
							Piece kingpiece = list.AddPickup(srcPieceLoc);
							Piece otherpiece = list.AddPickup( nextSquare );
							list.AddDrop( kingpiece, nextSquare );
							list.AddDrop( otherpiece, srcPieceLoc);
							list.EndMoveAdd( 0 );
						}
					}
				}
			}
		}
		/*
		public override void GetNotesForPieceType( PieceType type, List<string> notes )
		{
			if( type == srcPiece)
				notes.Add( "swap ability" );
		}
		*/
		protected Piece srcPiece;
		protected Piece dstPiece;
	}
}
