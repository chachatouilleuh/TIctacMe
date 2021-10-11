using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public Sprite spriteOne;
    public Sprite spriteTwo;

    public enum Turns
    {
        None = 0,
        PlayerOne = 1,
        PlayerTwo = 2,
        Victory = 3,
        Defeat = 4
    };
    public Turns currentTurn;
    public List<int> playerOneActions = new List<int>();
    public List<int> playerTwoActions = new List<int>();
    public Turns Victorious;


    // Start is called before the first frame update
    void Start()
    {
        currentTurn = Turns.PlayerOne;
    }

    public void changeTurn(int _id)
    {
        if (currentTurn == Turns.PlayerOne)
        {
            currentTurn = Turns.PlayerTwo;
            playerOneActions.Add(_id);
        }
        else if (currentTurn == Turns.PlayerTwo)
        {
            currentTurn = Turns.PlayerOne;
            playerTwoActions.Add(_id);
        }
        checkVictory(playerOneActions);
        checkVictory(playerTwoActions);
    }

    void checkVictory(List<int> _listToCheck)
    {
        bool _victory = false;

        // Lignes
       if (_listToCheck.Contains(1) && _listToCheck.Contains(2) && _listToCheck.Contains(3))
        {
            _victory = true;
        }
       else if (_listToCheck.Contains(4) && _listToCheck.Contains(5) && _listToCheck.Contains(6))
        {
            _victory = true;
        }
       else if (_listToCheck.Contains(7) && _listToCheck.Contains(8) && _listToCheck.Contains(9))
        {
            _victory = true;
        }

        // Colonnes
        if (_listToCheck.Contains(1) && _listToCheck.Contains(4) && _listToCheck.Contains(7))
        {
            _victory = true;
        }
        else if (_listToCheck.Contains(2) && _listToCheck.Contains(5) && _listToCheck.Contains(8))
        {
            _victory = true;
        }
        else if (_listToCheck.Contains(3) && _listToCheck.Contains(6) && _listToCheck.Contains(9))
        {
            _victory = true;
        }

        // Diagonales
        if (_listToCheck.Contains(1) && _listToCheck.Contains(5) && _listToCheck.Contains(9))
        {
            _victory = true;
        }
        else if (_listToCheck.Contains(3) && _listToCheck.Contains(5) && _listToCheck.Contains(7))
        {
            _victory = true;
        }
        if(_victory == true)
        {
            declareVictory(_listToCheck);
        }
    }

    void declareVictory(List<int> _listToCheck)
    {
        if (_listToCheck == playerOneActions) Victorious = Turns.PlayerOne;
        if (_listToCheck == playerTwoActions) Victorious = Turns.PlayerTwo;
        currentTurn = Turns.Victory;
        Debug.Log("Raccoony victory !!!" + Victorious);
    }

    void declareDefeat()
    {

    }
    
}