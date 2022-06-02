using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class SinkTrigger : MonoBehaviour
{
    public UiScript uiScript;
    public TextMeshProUGUI eText;

    public SinkGame sinkGame;
    public PlayerMovement playerMovement;
    public Lookingaround lookingAround;

    //  bool isCanvasActive;

    public GameObject SinkCanvas;

    private void OnTriggerEnter(Collider other)
    {
       if (other.gameObject.CompareTag("Player"))
       {
            uiScript.AppearingText();
            eText.text = "Press 'E' to use the sink";
       }
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            if(Input.GetKeyDown(KeyCode.E))
            {
                SinkCanvas.SetActive(true);
                sinkGame.toothpasteIsBeingApplied = true;
                playerMovement.enabled = false;
                lookingAround.enabled = false;
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            SinkCanvas.SetActive(false);
            uiScript.DissappearingText();
            //isCanvasActive = false;
        }
    }
}
