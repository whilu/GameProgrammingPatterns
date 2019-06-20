using UnityEngine;

public class RightCommand : Command
{
    public RightCommand(Actor actor)
    {
        _actor = actor;
    }
    public override void Execute()
    {
        _actor.Right();
    }
}
