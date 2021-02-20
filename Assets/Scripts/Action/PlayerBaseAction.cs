using UnityEngine;

public class PlayerBaseAction : MonoBehaviour
{

    protected virtual void Perform()
    {
        Debug.Log($"Performing ACTION {GetType()}!");
    }

}
