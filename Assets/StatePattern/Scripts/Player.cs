using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StatePattern
{
	public class Player
	{
		private State _state;
		
		public void Walk()
		{
			Debug.Log("Walk...!");
		}

		public void Run()
		{
			Debug.Log("Running...!");
		}

		public void Jump()
		{
			Debug.Log("Jump...!");
		}

		public void Slide()
		{
			Debug.Log("Slide...!");
		}
		
		public void SwitchState(KeyCode keyCode)
		{
			_state.Handle(keyCode);
		}

		public void SwitchState(State state)
		{
			_state = state;
			_state.Handle(0);
		}
	}

}
