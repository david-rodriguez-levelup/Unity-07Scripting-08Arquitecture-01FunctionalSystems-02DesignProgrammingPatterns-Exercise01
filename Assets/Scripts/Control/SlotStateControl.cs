﻿using UnityEngine;

public class SlotStateControl : MonoBehaviour
{
    private const int EMPTY = -1;

    [SerializeField] private CommandDataList commandDataList;
    [SerializeField] Sprite emptyIcon;

    public bool Locked { get; set; } = false;

    private IChangeSlotIconAction changeSlotIconAction;

    private int currentIndex = EMPTY;

    private void Awake()
    {
        changeSlotIconAction = GetComponentInChildren<IChangeSlotIconAction>();
    }

    private void Start()
    {
        Reset();
    }

    public CommandData Current => currentIndex != EMPTY ? commandDataList.Get(currentIndex) : null;

    public void Next()
    {
        currentIndex = (currentIndex + 1) % commandDataList.Length;
        UpdateIcon();
    }

    public void Random()
    {
        currentIndex = UnityEngine.Random.Range(0, commandDataList.Length);
        UpdateIcon();
    }

    public void Reset()
    {
        Locked = false;
        currentIndex = EMPTY;
        UpdateIcon();
    }

    private void UpdateIcon()
    {
        if (currentIndex == EMPTY)
        {
            changeSlotIconAction.Perform(emptyIcon);
        } 
        else
        {
            changeSlotIconAction.Perform(Current.Icon);
        }        
    }

}
