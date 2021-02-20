using System;
using UnityEngine;

[Serializable]
public class CommandData
{

    [SerializeField] private string name;
    [SerializeField] private Sprite icon;

    public string Name => name;

    public Sprite Icon => icon;

}
