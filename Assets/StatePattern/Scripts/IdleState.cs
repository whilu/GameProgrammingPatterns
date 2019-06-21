using System.Timers;
using UnityEngine;

namespace StatePattern
{
    public class IdleState : State
    {
        protected Player _player;

        public IdleState(Player player)
        {
            _player = player;
        }

    public void Handle()
    {
        _player.Idle();
        if (Input.GetKey(KeyCode.RightArrow))
        {
            _player.State = new WalkState(_player);
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
