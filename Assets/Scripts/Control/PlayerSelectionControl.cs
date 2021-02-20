using UnityEngine;

public class PlayerSelectionControl : MonoBehaviour
{

    [SerializeField] GameObject okButton;
    [SerializeField] EnemySelectionControl enemySelectionControl;

    private SlotStateControl[] slotStateControls;
    private IButtonSensor[] okButtonSensors;

    private bool locked = false;

    private void Awake()
    {
        slotStateControls = GetComponentsInChildren<SlotStateControl>();
        okButtonSensors = okButton.GetComponents<IButtonSensor>();
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
        foreach (IButtonSensor okButtonSensor in okButtonSensors)
        {
            okButtonSensor.OnPressed += CommitSlotList;
        }
    }

    private void OnDisable()
    {
        foreach (IButtonSensor okButtonSensor in okButtonSensors)
        {
            okButtonSensor.OnPressed -= CommitSlotList;
        }
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
        if (!locked)
        {
            locked = true;
            Debug.Log("PLAYER COMMANDS:");
            foreach (SlotStateControl slotState in slotStateControls)
            {
                slotState.Locked = true;
                if (slotState.Current != null)
                {
                    Debug.Log($"\t{slotState.Current.Name}");
                }
                else
                {
                    Debug.Log($"\tEMPTY");
                }
            }
            enemySelectionControl.RandomSelection();
        }
    }

}
