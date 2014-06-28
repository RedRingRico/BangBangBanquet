using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace BangBangBanquet.Game
{
	public sealed class GameStateManager
	{
		private GameStateManager( )
		{
			m_GameStateRegistry = new System.Set< GameState >( );
			m_GameStateStack = new Stack< GameState >( );
			m_Quit = false;
		}

		public int PushState( string p_StateName )
		{
			GameState NewState = null;

			foreach( GameState State in m_GameStateRegistry )
			{
				if( p_StateName == State.Name )
				{
					NewState = State;
					break;
				}
			}

			if( NewState != null )
			{
				m_GameStateStack.Push( NewState );
				m_GameStateStack.Peek( ).Enter( );

				return DataTypes.OK;
			}

			return DataTypes.FAIL;
		}

		public void PopState( )
		{
			if( m_GameStateStack.Count > 0 )
			{
				m_GameStateStack.Peek( ).Exit( );
				m_GameStateStack.Pop( );
			}
		}

		public void PopAllStates( )
		{
			while( m_GameStateStack.Count > 0 )
			{
				this.PopState( );
			}
		}

		public void Execute( )
		{
			if( m_GameStateStack.Count > 0 )
			{
				m_GameStateStack.Peek( ).Execute( );
			}
			else
			{
				m_Quit = true;
			}
		}

		public int RegisterState( GameState p_Register )
		{
			m_GameStateRegistry.Add( p_Register );

			return DataTypes.OK;
		}

		public void Quit( )
		{
			this.PopAllStates( );

			m_Quit = true;
		}

		public bool Running
		{
			get
			{
				return !m_Quit;
			}
		}

		public Renderer.Renderer Renderer
		{
			get
			{
				return m_Renderer;
			}
			set
			{
				m_Renderer = value;
			}
		}

		private bool					m_Quit;
		private Stack< GameState >		m_GameStateStack;
		private System.Set< GameState > m_GameStateRegistry;
		private Renderer.Renderer		m_Renderer;

		public static readonly GameStateManager Instance =
			new GameStateManager( );
	}
}
