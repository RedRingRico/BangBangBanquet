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

	[ StructLayout( LayoutKind.Explicit ) ]
	public struct ModelHeader
	{
		[ FieldOffset( 0 ) ]
		public char ID;
		[ FieldOffset( 4 ) ]
		public uint MeshCount;
	}
}
