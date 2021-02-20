using System;
using UnityEngine;

public class OnKeyDownButtonSensor : MonoBehaviour, IButtonSensor
{

    public event Action OnPressed;

    [SerializeField] KeyCode keyCode = KeyCode.Alpha1;

    private void Update()
    {
        if (Input.GetKeyDown(keyCode))
        {
            OnPressed?.Invoke();
        }
    }

}
