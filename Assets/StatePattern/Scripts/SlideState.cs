using System.Timers;
using UnityEngine;

namespace StatePattern
{
	public class SlideState : State
	{
		protected Player _player;

		public SlideState(Player player)
		{
			_player = player;
		}

		public void Handle()
		{
			if (!Input.GetKeyDown(KeyCode.RightShift))
			{
				return;
			}

			
			_player.Slide();
			
			Timer timer = new Timer(5000);
			timer.AutoReset = false;
			timer.Enabled = true;
			timer.Elapsed += new ElapsedEventHandler(SlideFinished);
			timer.Start();
			
			// Do nothing for input
		}
		
		private void SlideFinished(object obj, ElapsedEventArgs args)
		{
			Debug.Log("Slide Done! Switch to Run state...");
			_player.State = new IdleState(_player);
		}
	}
}
