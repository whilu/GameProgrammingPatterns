using UnityEngine;

namespace StatePattern
{
	public class JumpState : State
	{
		protected Player _player;
		
		public JumpState(Player player)
		{
			_player = player;
		}
		
		public void Handle(KeyCode keyCode)
		{
			_player.Jump();
		}
	}
}
