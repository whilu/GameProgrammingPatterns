using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace StatePattern
{
	public class GameController : MonoBehaviour
	{

		private Player _player;

		private void Awake()
		{
			_player = new Player();
		}

		void Update () {
			if (Input.GetKeyDown(KeyCode.RightArrow))
			{
				_player.SwitchState(KeyCode.RightArrow);
			}
		}
	}

}

