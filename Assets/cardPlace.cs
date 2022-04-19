using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cardPlace : MonoBehaviour
{

    public card card;
    player player;

    public bool isPlayerPlace;

    private void Start()
    {

        player = GameObject.Find("hand").GetComponent<player>();

    }

    private void OnMouseDown()
    {

        if (player.selectedCard != null && card == null && isPlayerPlace) { 
        
            card = player.selectedCard;
            StartCoroutine(movingStuff.move(player.selectedCard.gameObject, gameObject.transform.position + new Vector3(0, 0.01f, 0)));
            StartCoroutine(movingStuff.rotate(player.selectedCard.gameObject, Quaternion.Euler(90,0,0),24));
            player.hand.Remove(card);
            card.inHand = false;
        
        }

    }

}