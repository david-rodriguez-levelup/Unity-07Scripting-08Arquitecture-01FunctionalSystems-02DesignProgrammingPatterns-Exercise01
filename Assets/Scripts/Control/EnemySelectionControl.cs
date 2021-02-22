using UnityEngine;

public class EnemySelectionControl : MonoBehaviour
{

    private SlotState[] slotStateControls;

    private void Awake()
    {
        slotStateControls = GetComponentsInChildren<SlotState>();
    }

    public void RandomSelection()
    {
        /// TODO: Add juice to this!
        foreach (SlotState slotState in slotStateControls)
        {
            slotState.Random();
        }
        CommitSlotList();
    }

    public void ResetSlotList()
    {
        foreach (SlotState slotState in slotStateControls)
        {
            slotState.Reset();
        }
    }

    private void CommitSlotList()
    {
Debug.Log("ENEMY COMMANDS:");
        foreach (SlotState slotState in slotStateControls)
        {
Debug.Log($"\t{slotState.Current.Id}");
        }
    }

}
