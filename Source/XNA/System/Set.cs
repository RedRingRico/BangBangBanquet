using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace BangBangBanquet.System
{
	public class Set< T >
	{
		public Set( )
		{
			m_List = new List< T >( );
		}

		public int Add( T p_Item )
		{
			foreach( T Type in m_List )
			{
				if( Type.Equals( p_Item ) )
				{
					return DataTypes.OK;
				}
			}

			m_List.Add( p_Item );

			return DataTypes.OK;
		}

		public void Remove( T p_Item )
		{
			foreach( T Type in m_List )
			{
				if( Type.Equals( p_Item ) )
				{
					m_List.Remove( Type );
				}
			}
		}

		public void Print( )
		{
			if( m_List.Count > 0 )
			{
				Debug.WriteLine( "1 item in the set" );
			}
			else
			{
				Debug.WriteLine( "{0} items in the set", m_List.Count );
			}

			for( int i = 0; i < m_List.Count; ++i )
			{
				Debug.WriteLine( "[{0}] {1}", i, m_List[ i ].ToString( ) );
			}
		}

		public bool IsEmpty( )
		{
			return m_List.Count > 0 ? true : false;
		}

		public IEnumerator< T > GetEnumerator( )
		{
			return m_List.GetEnumerator( );
		}

		private List< T > m_List;
	}
}
