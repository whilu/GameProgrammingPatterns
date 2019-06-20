using UnityEngine;

public class UpCommand : Command
{

    public UpCommand(Actor actor)
    {
        _actor = actor;
    }
    public override void Execute()
    {
        _actor.Up();
    }
}
