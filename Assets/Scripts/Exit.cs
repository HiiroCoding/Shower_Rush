using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Exit : MonoBehaviour
{
    public UiScript uiScript;
    public TextMeshProUGUI exitText;


    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            uiScript.AppearingText();
            exitText.text = "Press 'E' to exit";
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            print("Quit");
            Application.Quit();
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            uiScript.DissappearingText();
        }
    }
}
