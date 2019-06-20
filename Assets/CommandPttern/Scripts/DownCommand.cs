using UnityEngine;

public class DownCommand : Command
{
    public DownCommand(Actor actor)
    {
        _actor = actor;
    }
    public override void Execute()
    {
        _actor.Down();
    }
}
