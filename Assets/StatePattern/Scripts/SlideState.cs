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

		public void Handle(KeyCode keyCode)
		{
			_player.Slide();
			Timer timer = new Timer(2000);
			timer.AutoReset = false;
			timer.Enabled = true;
			timer.Elapsed += new ElapsedEventHandler(SlideDone);
			timer.Start();
		}

		private void SlideDone(object obj, ElapsedEventArgs args)
		{
			Debug.Log("Slide Done! Switch to Run state...");
			_player.SwitchState(0);
		}
	}
}
