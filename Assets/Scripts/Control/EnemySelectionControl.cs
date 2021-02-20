using UnityEngine;

public class EnemySelectionControl : MonoBehaviour
{

    private SlotStateControl[] slotStateControls;

    private void Awake()
    {
        slotStateControls = GetComponentsInChildren<SlotStateControl>();
    }

    public void RandomSelection()
    {
        foreach (SlotStateControl slotState in slotStateControls)
        {
            slotState.Random();
        }
        CommitSlotList();
    }

    public void ResetSlotList()
    {
        foreach (SlotStateControl slotState in slotStateControls)
        {
            slotState.Reset();
        }
    }

    private void CommitSlotList()
    {
Debug.Log("ENEMY COMMANDS:");
        foreach (SlotStateControl slotState in slotStateControls)
        {
Debug.Log($"\t{slotState.Current.Name}");
        }
    }

}
