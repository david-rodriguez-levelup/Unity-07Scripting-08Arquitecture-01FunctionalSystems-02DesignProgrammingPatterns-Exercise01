using System;
using UnityEngine;

public class PlayerSelectionControl : MonoBehaviour
{
    [SerializeField] TurnManager turnManager;
    [SerializeField] GameObject commandReceiver;

    [SerializeField] GameObject okButton;
    [SerializeField] EnemySelectionControl enemySelectionControl;

    private SlotState[] slotStateControls;
    private IInputSensor[] okInputSensors;

    private bool locked = false;

    private void Awake()
    {
        slotStateControls = GetComponentsInChildren<SlotState>();
        okInputSensors = okButton.GetComponents<IInputSensor>();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            locked = false;
            ResetSlotList();
            enemySelectionControl.ResetSlotList();
        }
    }

    private void OnEnable()
    {
        foreach (IInputSensor okButtonSensor in okInputSensors)
        {
            okButtonSensor.OnPressed += CommitSlotList;
        }
    }

    private void OnDisable()
    {
        foreach (IInputSensor okButtonSensor in okInputSensors)
        {
            okButtonSensor.OnPressed -= CommitSlotList;
        }
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
        if (!locked)
        {
            locked = true;
            Debug.Log("PLAYER COMMANDS:");
            foreach (SlotState slotState in slotStateControls)
            {
                slotState.Locked = true;
                if (slotState.Current != null)
                {
                    Debug.Log($"\t{slotState.Current.Id}");
                    CreateCommand(slotState.Current.Id);
                }
                else
                {
                    Debug.Log($"\tEMPTY");
                }
            }
            enemySelectionControl.RandomSelection();
        }
    }

    private void CreateCommand(string id)
    {
        ICommandAction[] actions = commandReceiver.GetComponents<ICommandAction>();

        foreach (ICommandAction action in actions)
        {
            if (action.Id.Equals(id, StringComparison.OrdinalIgnoreCase))
            {
                ICommand command = new DefaultCommand(action);
                turnManager.AddPlayerCommand(command);
            }
        }

    }

}
