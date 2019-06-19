using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    private LeftCommand _leftCommand;

    private RightCommand _rightCommand;

    private UpCommand _upCommand;

    private DownCommand _downCommand;
    
    void Awake()
    {
        _leftCommand = new LeftCommand();
        _rightCommand = new RightCommand();
        _upCommand = new UpCommand();
        _downCommand = new DownCommand();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            _leftCommand.Execute();
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            _rightCommand.Execute();
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            _upCommand.Execute();
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            _downCommand.Execute();
        }
    }
}
