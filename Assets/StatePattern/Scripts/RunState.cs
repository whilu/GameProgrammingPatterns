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
		
		public void Handle()
		{
			_player.Run();
			if (Input.GetKeyDown(KeyCode.RightShift))
			{
				_player.State = new SlideState(_player);
				_player.SwitchState();
			}
			else if (Input.GetKeyDown(KeyCode.Space))
			{
				_player.State = new JumpState(_player);
				_player.SwitchState();
			}
			else if(Input.GetKeyUp(KeyCode.LeftShift))
			{
				_player.State = new WalkState(_player);
				_player.SwitchState();
			}
			else if(Input.GetKeyUp(KeyCode.RightArrow))
			{
				_player.State = new IdleState(_player);
				_player.SwitchState();
			}
		}
	}
}
