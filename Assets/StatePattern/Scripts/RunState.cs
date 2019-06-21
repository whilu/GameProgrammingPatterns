using UnityEngine;

namespace StatePattern
{
	public class RunState : State
	{
		protected Player _player;
		
		public RunState(Player player)
		{
			_player = player;
		}
		
		public void Handle(KeyCode keyCode)
		{
			_player.Run();
		}
	}
}
