using UnityEngine;

public class PlayerSlotInputControl : MonoBehaviour
{

    private SlotStateControl slotState;
    private IButtonSensor[] buttonSensors;

    private void Awake()
    {
        slotState = GetComponent<SlotStateControl>();
        buttonSensors = GetComponents<IButtonSensor>();
    }

    private void OnEnable()
    {
        foreach (IButtonSensor slotSensor in buttonSensors)
        {
            slotSensor.OnPressed += SelectNext;
        }
    }

    private void OnDisable()
    {
        foreach (IButtonSensor slotSensor in buttonSensors)
        {
            slotSensor.OnPressed -= SelectNext;
        }
    }

    private void SelectNext()
    {
        if (!slotState.Locked)
        {
            slotState.Next();
        } 
    }   

}
