using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.UIElements;

public class GameController : MonoBehaviour
{
    private Command _leftCommand;

    private Command _rightCommand;

    private Command _upCommand;

    private Command _downCommand;

    public Actor _Actor1;
    public Actor _Actor2;
    
    void Awake()
    {
        _leftCommand = new LeftCommand();
        _rightCommand = new RightCommand();
        _upCommand = new UpCommand();
        _downCommand = new DownCommand();
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
//            _Actor1.Left();
            ExecuteCommand(_leftCommand, _Actor1);
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
//            _Actor1.Right();
            ExecuteCommand(_rightCommand, _Actor1);
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
//            _Actor1.Up();
            ExecuteCommand(_upCommand, _Actor1);
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
//            _Actor1.Down();
            ExecuteCommand(_downCommand, _Actor1);
        }
    }

    void ExecuteCommand(Command command, Actor actor)
    {
        command.Execute(actor);
    }
}
