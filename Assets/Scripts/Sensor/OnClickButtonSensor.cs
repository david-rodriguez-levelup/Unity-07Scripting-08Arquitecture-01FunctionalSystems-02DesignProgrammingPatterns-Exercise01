using System;
using UnityEngine;
using UnityEngine.UI;

public class OnClickButtonSensor : MonoBehaviour, IButtonSensor
{

	public event Action OnPressed;

	void Start()
	{
		Button button = GetComponent<Button>();
		button.onClick.AddListener(TaskOnClick);
	}

	void TaskOnClick()
	{
		OnPressed?.Invoke();
	}

}
