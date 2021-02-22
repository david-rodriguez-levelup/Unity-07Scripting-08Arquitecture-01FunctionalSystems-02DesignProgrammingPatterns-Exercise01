using UnityEngine;

public class PlayerAttackAction : ICommandAction
{
    private const string ID = "ATTACK";

    public string Id => ID;

    public void Perform()
    {
        Debug.Log($"Performing ACTION {ID}!");
    }
}
