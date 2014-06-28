using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace BangBangBanquet.Game
{
	public class MenuGameState : GameState
	{
		public MenuGameState( ) : base( "Menu" )
		{
			Debug.WriteLine( "{0}: Creating", m_Name );
		}

		public override void Enter( )
		{
			GameStateManager.Instance.Renderer.SetClearColour( 32, 96, 32 );
			Debug.WriteLine( "{0}: Entering", m_Name );
		}

		public override void Exit( )
		{
			Debug.WriteLine( "{0}: Exiting", m_Name );
		}

		public override void Execute( )
		{
			GameStateManager.Instance.Renderer.BeginScene( );
			GameStateManager.Instance.Renderer.EndScene( );
		}
	}
}
