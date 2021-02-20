using UnityEngine;

public class BaseCommand : ICommand
{

    public virtual void Execute()
    {
        Debug.Log($"Executing COMMAND {GetType()}!");
    }

}
