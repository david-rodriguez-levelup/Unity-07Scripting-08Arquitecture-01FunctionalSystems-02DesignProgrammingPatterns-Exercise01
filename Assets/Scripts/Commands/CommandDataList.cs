using UnityEngine;

[CreateAssetMenu(fileName = "CommandDataList", menuName = "Assets/CommandDataList")]
public class CommandDataList : ScriptableObject
{

    [SerializeField] private CommandData[] commandDataList;

    public int Length => commandDataList.Length;

    public CommandData Get(int index)
    {
        return commandDataList[index];
    }

}
