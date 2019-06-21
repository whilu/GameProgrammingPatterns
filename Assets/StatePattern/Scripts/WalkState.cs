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
		
		public void Handle()
		{
			_player.Walk();
			
			if (Input.GetKeyUp(KeyCode.RightArrow))
			{
				_player.State = new IdleState(_player);
				_player.SwitchState();
			}
			else if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey(KeyCode.RightArrow))
			{
				_player.State = new RunState(_player);
				_player.SwitchState();
			}
			else if (Input.GetKeyDown(KeyCode.Space))
			{
				_player.State = new JumpState(_player);
				_player.SwitchState();
			}
			
		}
	}
}
