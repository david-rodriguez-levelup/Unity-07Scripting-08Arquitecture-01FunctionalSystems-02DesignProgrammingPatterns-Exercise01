using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDefenseAction : ICommandAction
{
    private const string ID = "DEFENSE";

    public string Id => ID;

    public void Perform()
    {
        Debug.Log($"Performing ACTION {ID}!");
    }
}
