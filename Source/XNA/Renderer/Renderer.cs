using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace BangBangBanquet.Renderer
{
	class Renderer
	{
		public Renderer( )
		{
		}

		public int Initialise( )
		{
			m_Adapter = GraphicsAdapter.DefaultAdapter;

			PresentationParameters Presentation =
				new PresentationParameters( );

			Presentation.BackBufferWidth = m_Adapter.CurrentDisplayMode.Width;
			Presentation.BackBufferHeight =
				m_Adapter.CurrentDisplayMode.Height;
			Presentation.BackBufferFormat = SurfaceFormat.Color;
			Presentation.DepthStencilFormat = DepthFormat.Depth24Stencil8;

			m_Device = new GraphicsDevice( m_Adapter, GraphicsProfile.HiDef,
				Presentation );

			return DataTypes.OK;
		}

		public void SetClearColour( byte p_Red, byte p_Green, byte p_Blue )
		{
			m_ClearColour.R = p_Red;
			m_ClearColour.G = p_Green;
			m_ClearColour.B = p_Blue;
			m_ClearColour.A = 255;
		}

		public int BeginScene( )
		{
			m_Device.Clear( m_ClearColour );
			return DataTypes.OK;
		}

		public void EndScene( )
		{
			m_Device.Present( );
		}

		private GraphicsDevice	m_Device;
		private GraphicsAdapter	m_Adapter;
		private Color			m_ClearColour;
	}
}
