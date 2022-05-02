using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class getDiscardNum : MonoBehaviour
{

    Text text;
    discard table;
    bool isDone = false;

    private void Start()
    {
        
        text = GetComponent<Text>();
        table = GameObject.Find("table").GetComponent<discard>();

        StartCoroutine(dialog());

    }

    private void Update()
    {
        if (isDone)
        {

            text.text = "Discard " + table.numDiscard + " cards";

        }


    }

    IEnumerator dialog() {

        yield return typingText("What a shame");
        yield return new WaitForSeconds(1);
        yield return typingText("you lost");
        yield return new WaitForSeconds(1);
        yield return typingText("discard more cards");
        yield return new WaitForSeconds(1);
        isDone = true;


    }

    IEnumerator typingText(string message) {

        for (int i = 1; i <= message.Length; i++) { 
        
            text.text = message.Substring(0,i);

            yield return new WaitForSeconds(.05f);
        
        }
    
    }

}
