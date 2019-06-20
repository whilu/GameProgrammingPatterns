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

    private Actor _Actor1 = new Actor();
    private Actor _Actor2 = new Actor();
    
    void Awake()
    {
        _leftCommand = new LeftCommand(_Actor1);
        _rightCommand = new RightCommand(_Actor1);
        _upCommand = new UpCommand(_Actor1);
        _downCommand = new DownCommand(_Actor1);
    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
//            _Actor1.Left();
            ExecuteCommand(new LeftCommand(_Actor1));
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
//            _Actor1.Right();
            ExecuteCommand(new RightCommand(_Actor1));
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
//            _Actor1.Up();
            ExecuteCommand(new UpCommand(_Actor1));
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
//            _Actor1.Down();
            ExecuteCommand(new DownCommand(_Actor1));
        }
        else if(Input.GetKeyDown(KeyCode.Z))
        {
            Undo();
        }
        else if(Input.GetKeyDown(KeyCode.Y))
        {
            Do();
        }
    }

    private List<Command> _commands = new List<Command>();
    private int _curCommandIdx = -1;
    void ExecuteCommand(Command command)
    {
        // change command index
        _curCommandIdx++;
        // push command
        _commands.Add(command);
        // execute command
        _commands[_curCommandIdx].Execute();
    }

    void Undo()
    {
        _curCommandIdx--;
        _commands[_curCommandIdx].Execute();
    }

    void Do()
    {
        _curCommandIdx++;
        _commands[_curCommandIdx].Execute();
    }
}
