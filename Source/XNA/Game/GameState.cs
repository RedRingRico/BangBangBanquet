using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BangBangBanquet.Game
{
	public abstract class GameState
	{
		public abstract void Enter( );
		public abstract void Exit( );
		public abstract void Execute( );

		public GameState( string p_Name )
		{
			m_Name = p_Name;
		}

		public override string ToString( )
		{
			return string.Format( "GameState: \"{0}\"", m_Name );
		}

		public string Name
		{
			get
			{
				return m_Name;
			}
		}
		protected string				m_Name;
	}
}
