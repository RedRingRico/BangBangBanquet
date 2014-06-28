using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading;

namespace BangBangBanquet
{
	class BangBangBanquet
	{
		static int Main( string [ ] p_Args )
		{
			Game.Game TheGame = new Game.Game( );
			/*
			System.Set< int > TestSet = new System.Set< int >( );

			TestSet.Add( 10 );
			TestSet.Add( 10 );
			TestSet.Add( 11 );

			TestSet.Print( );

			Debug.WriteLine( "Resolution: {0}", Environment.TickCount );
			Debug.WriteLine( "OS: {0}", Environment.OSVersion );
			if( Stopwatch.IsHighResolution )
			{
				Debug.WriteLine( "High res timer" );
				Debug.WriteLine( "Frequency: {0}", Stopwatch.Frequency );
			}

			Stopwatch Watch = new Stopwatch( );
			Watch.Start( );

			Thread.Sleep( 1000 );

			Watch.Stop( );
			//TimeSpan Time = Watch.ElapsedTicks;
			long Nanoseconds = (1000L*1000L*1000L) / Stopwatch.Frequency;
			Debug.WriteLine( "{0}", Watch.ElapsedTicks * Nanoseconds );
			Debug.WriteLine( "{0}", Nanoseconds );*/

			if( TheGame.Initialise( ) != DataTypes.OK )
			{
				return DataTypes.FAIL;
			}

			return TheGame.Execute( );
		}
	}
}
