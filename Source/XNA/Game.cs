using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Input;

namespace BangBangBanquet
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

			while( m_Run )
			{
				m_GamePad = GamePad.GetState( PlayerIndex.One );
				if( m_GamePad.Buttons.Start == ButtonState.Pressed &&
					OldGamePad.Buttons.Start == ButtonState.Released )
				{
					m_Run = false;
				}

				m_Renderer.BeginScene( );
				m_Renderer.EndScene( );

				OldGamePad = m_GamePad;
			}

			return DataTypes.OK;
		}

		private GamePadState		m_GamePad;
		private Renderer.Renderer	m_Renderer;
		private bool				m_Run;
	}
}
