using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BangBangBanquet
{
	class BangBangBanquet
	{
		static int Main( string [ ] p_Args )
		{
			Game TheGame = new Game( );

			if( TheGame.Initialise( ) != DataTypes.OK )
			{
				return DataTypes.FAIL;
			}

			return TheGame.Execute( );
		}
	}
}
