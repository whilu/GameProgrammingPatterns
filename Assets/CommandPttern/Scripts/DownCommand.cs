using UnityEngine;

public class DownCommand : Command
{
    public override void Execute(Actor actor)
    {
        actor.Down();
    }
}
