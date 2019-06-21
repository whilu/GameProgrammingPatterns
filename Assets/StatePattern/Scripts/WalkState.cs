using UnityEngine;

namespace StatePattern
{
	public class WalkState : State
	{
		protected Player _player;
		
		public WalkState(Player player)
		{
			_player = player;
		}
		
		public void Handle(KeyCode keyCode)
		{
			_player.Walk();
		}
	}
}
