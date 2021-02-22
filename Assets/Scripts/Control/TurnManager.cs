using System.Collections.Generic;
using UnityEngine;

public class TurnManager : MonoBehaviour
{

    private List<ICommand> playerCommands;
    private List<ICommand> enemyCommands;

    public void AddPlayerCommand(ICommand command)
    {
        Debug.Log($"Command {command.GetType()} added to player's commands.");
        playerCommands.Add(command);
    }

    public void AddEnemyCommand(ICommand command)
    {
        Debug.Log($"Command {command.GetType()} added to enemy's commands.");
        enemyCommands.Add(command);
    }

}
