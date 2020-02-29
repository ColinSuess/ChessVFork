using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChessV.Games
{
	#region Queen
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

}
