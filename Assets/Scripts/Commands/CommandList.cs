using UnityEngine;

[CreateAssetMenu(fileName = "CommandDataList", menuName = "Assets/CommandDataList")]
public class CommandList : ScriptableObject
{

    [SerializeField] private CommandDef[] commandDTOs;

    public int Length => commandDTOs.Length;

    public CommandDef Get(int index)
    {
        return commandDTOs[index];
    }

}
