using System;
using Microsoft.Xna.Framework;

namespace Microsoft.Xna.Framework.Input
{
	public static class GamePad
	{
		public static GamePadCapabilities GetCapabilities (PlayerIndex playerIndex)
		{
			return new GamePadCapabilities (); /* no capabilities, and not connected */
		}
		
		public static GamePadState GetState (PlayerIndex playerIndex, GamePadDeadZone deadZoneMode)
		{
			return GamePadState.InitializedState;
		}
		
		public static GamePadState GetState (PlayerIndex playerIndex)
		{
			return GetState (playerIndex, GamePadDeadZone.IndependentAxes);
		}
		
		public static bool SetVibration (PlayerIndex playerIndex, float leftMotor, float rightMotor)
		{
			return false;
		}
	}
}

