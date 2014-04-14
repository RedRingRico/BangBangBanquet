using System.IO;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System.Runtime.InteropServices;

namespace BangBangBanquet.Renderer
{
	class Model
	{
		public Model( )
		{
		}

		public int LoadFromFile( ref string p_FilePath )
		{
			try
			{
				Stream ModelStream = TitleContainer.OpenStream( p_FilePath );
				StreamReader Reader = new StreamReader( ModelStream );

				// The file is laid out like so:
				// Header
				// n Chunks consisting of:
				//	Mesh data (indices, vertices, vertex type, Material ID)
				//	Skeletal data (if present)
				//	Meta data - Name

				// The header contains
				// Mesh count
				ModelStream.Close( );
			}
			catch( FileNotFoundException Exception )
			{
			}

			return DataTypes.OK;
		}
	}

	//[StructLayout(LayoutKind.Pack)]
	public struct ModelHeader
	{
		public char ID0, ID1, ID2, ID3;
		public uint MeshCount;
	}
}
