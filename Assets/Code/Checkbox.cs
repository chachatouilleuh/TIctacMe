using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class Checkbox : MonoBehaviour, IPointerEnterHandler, IPointerClickHandler, IPointerExitHandler
{
    // Start is called before the first frame update

    // Définition de l'enum (réutilisable par d'autres)
    public enum playerState
    {
        None = 0,
        PlayerOne = 1,
        PlayerTwo
    }

    // Variables de la classe

    public Sprite Check;
    public playerState currentContent;
    GameCtrl myGame;

    void Start()
    {
        //HoverMe();
        myGame = FindObjectOfType<GameCtrl>();
        
    }

    

    // Update is called once per frame
    void Update()
    {
      
    }
    public void HoverMe()
    {
        Debug.Log("I'm here" + name, this);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("Enter Me" + name, this);

    }

    public void OnPointerClick(PointerEventData eventData)
    {
        Debug.Log("Click Me" + name, this);
        GetComponent<Image>().sprite = myGame.playerOneCheckbox;
        currentContent = playerState.PlayerOne;

    }

    public void OnPointerExit(PointerEventData eventData)
    {
        Debug.Log("Exit Me" + name, this);
    }
}
