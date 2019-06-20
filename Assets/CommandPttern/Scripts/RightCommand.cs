using UnityEngine;

public class RightCommand : Command
{
    public override void Execute(Actor actor)
    {
        actor.Right();
    }
}
