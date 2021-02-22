using UnityEngine;

public class PlayerHealingAction : ICommandAction
{
   private const string ID = "HEALING";

    public string Id => ID;

    public void Perform()
    {
        Debug.Log($"Performing ACTION {ID}!");
    }
}
