using UnityEngine;

public class LeftCommand : Command
{
    public override void Execute(Actor actor)
    {
        actor.Left();
    }
}
