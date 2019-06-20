using UnityEngine;

public class LeftCommand : Command
{
    public LeftCommand(Actor actor)
    {
        _actor = actor;
    }
    public override void Execute()
    {
        _actor.Left();
    }
}
