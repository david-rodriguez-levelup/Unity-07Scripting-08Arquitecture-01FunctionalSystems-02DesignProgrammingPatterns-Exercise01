using System;
using UnityEngine;

[Serializable]
public class CommandDef
{

    [SerializeField] private string id;
    [SerializeField] private Sprite icon;

    public string Id => id;

    public Sprite Icon => icon;

}
