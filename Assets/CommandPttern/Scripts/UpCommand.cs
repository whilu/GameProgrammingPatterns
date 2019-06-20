using UnityEngine;

public class UpCommand : Command
{
    public override void Execute(Actor actor)
    {
        actor.Up();
    }
}
