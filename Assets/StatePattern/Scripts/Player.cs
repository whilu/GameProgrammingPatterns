using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StatePattern
{
	public class Player : MonoBehaviour
	{
		private State _state;

		public State State
		{
			set => _state = value;
		}

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

		public void Idle()
		{
			Debug.Log("Idle...!");	
		}
		
		public void SwitchState()
		{
			_state.Handle();
		}

		private void Start()
		{
			// init state
			State = new IdleState(this);
		}

		private void Update()
		{
			SwitchState();
		}
	}

}
