using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Checkbox : MonoBehaviour, IPointerClickHandler, IPointerEnterHandler
{
    // Variables de la classe

    public GameController Game;
    public int ID;
    bool canClick;

    void Start()
    {
        Game = FindObjectOfType<GameController>();
        canClick = true;
    }



    public void OnPointerClick(PointerEventData eventData)
    {
        if (!canClick) return;
        if (Game.currentTurn == GameController.Turns.Victory || Game.currentTurn == GameController.Turns.Defeat) return;
        canClick = false;


        if(Game.currentTurn == GameController.Turns.PlayerOne)
        {
            GetComponent<Image>().sprite = Game.spriteOne;
        }
        else if(Game.currentTurn == GameController.Turns.PlayerTwo)
        {
            GetComponent<Image>().sprite = Game.spriteTwo;
        }
        Game.changeTurn(ID);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {

    }
}
