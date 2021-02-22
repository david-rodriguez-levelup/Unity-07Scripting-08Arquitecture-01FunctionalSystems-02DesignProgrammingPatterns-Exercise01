using UnityEngine;

public class DefaultCommand : ICommand
{

    private readonly ICommandAction action;

    public DefaultCommand(ICommandAction _action)
    {
        action = _action;
    }

    public virtual void Execute()
    {
        Debug.Log($"Executing COMMAND {action.Id}!");
        action.Perform();
    }

}
