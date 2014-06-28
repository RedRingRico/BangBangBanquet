using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace BangBangBanquet.Game
{
	class Game
	{
		public Game( )
		{
		}

		public int Initialise( )
		{
			m_Renderer = new Renderer.Renderer( );

			if( m_Renderer.Initialise( ) != DataTypes.OK )
			{
				return DataTypes.FAIL;
			}

			m_Renderer.SetClearColour( 0x99, 0x33, 0xFF );
			m_Run = true;

			return DataTypes.OK;
		}

		public int Execute( )
		{
			GamePadState	OldGamePad = GamePad.GetState( PlayerIndex.One );
			GamePadCapabilities GamePadCaps =
				GamePad.GetCapabilities( PlayerIndex.One );

			if( GamePadCaps.GamePadType == GamePadType.ArcadeStick )
			{
				// Display overlay for Arcade Stick
			}
			else if( GamePadCaps.GamePadType == GamePadType.GamePad )
			{
				// Display overlay for regular controller
			}
			else
			{
				// Unrecognised controller, wait for user to connect a valid
				// input device
			}

			GameStateManager.Instance.Renderer = m_Renderer;

			GameStateManager.Instance.RegisterState( new MenuGameState( ) );
			GameStateManager.Instance.PushState( "Menu" );

			while( GameStateManager.Instance.Running )
			{
				// Input should be handled by the Game State Manager
				m_GamePad = GamePad.GetState( PlayerIndex.One );
				if( m_GamePad.Buttons.Start == ButtonState.Pressed &&
					OldGamePad.Buttons.Start == ButtonState.Released )
				{
					GameStateManager.Instance.Quit( );
				}

				OldGamePad = m_GamePad;

				GameStateManager.Instance.Execute( );
			}

			return DataTypes.OK;
		}

		private GamePadState		m_GamePad;
		private Renderer.Renderer	m_Renderer;
		private bool				m_Run;
	}
}