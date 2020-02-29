﻿
/***************************************************************************

                                 ChessV

                  COPYRIGHT (C) 2012-2017 BY GREG STRONG

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

using System;

public class Statistics
{
	public DateTime SearchStartTime { get; set; }

	public long Nodes { get; set; }
	public long QNodes { get; set; }

	public long PawnHashLookups { get; set; }
	public long PawnHashHits { get; set; }

	public long MaterialHashLookups { get; set; }
	public long MaterialHashHits { get; set; }

	public void Reset()
	{
		Nodes = 0;
		QNodes = 0;
		PawnHashLookups = 0;
		PawnHashHits = 0;
		MaterialHashLookups = 0;
		MaterialHashHits = 0;
	}
}
