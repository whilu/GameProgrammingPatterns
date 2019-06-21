using System.Timers;
using UnityEngine;

namespace StatePattern
{
	public class JumpState : State
	{
		private static bool _sIsJumping = false;
		
		protected Player _player;
		
		public JumpState(Player player)
		{
			_player = player;
		}
		
		public void Handle()
		{
			if (!Input.GetKeyDown(KeyCode.Space) || _sIsJumping)
			{
				return;
			}
	
			_sIsJumping = true;
			_player.Jump();
			
			Timer timer = new Timer(2000);
			timer.AutoReset = false;
			timer.Enabled = true;
			timer.Elapsed += new ElapsedEventHandler(JumpFinished);
			timer.Start();
			
			// Do nothing for input
		}
		
		private void JumpFinished(object obj, ElapsedEventArgs args)
		{
			Debug.Log("Jump Done! Switch to Run state...");
			_sIsJumping = false;
			_player.State = new IdleState(_player);
		}
	}
}
