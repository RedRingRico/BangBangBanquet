using System;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

namespace BangBangBanquet.Renderer
{
	class Mesh
	{
		public Mesh( ref GraphicsDevice p_GraphicsDevice )
		{
			m_GraphicsDevice = p_GraphicsDevice;
		}

		private GraphicsDevice		m_GraphicsDevice;
		private IndexBuffer			m_IndexBuffer;
		private VertexBuffer		m_VertexBuffer;
		private VertexDeclaration	m_VertexDeclaration;
		// private Material	m_Material;
	}
}
