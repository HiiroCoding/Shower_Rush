using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ColliderShower : MonoBehaviour
{
    public UiScript uiScript;
    public TextMeshProUGUI eText;

    bool playerIsInside;
    bool interactable = true;
    bool miniGameOn;

    public ShoweNeedle showerNeedle;
    public PlayerMovement playerMovement;
    public Lookingaround lookingAround;

    public GameObject indicator;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player") && interactable)
        {
            uiScript.AppearingText();
            eText.text = "Press 'E' to use the shower";
            playerIsInside = true;

        }
        else
        {

        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.CompareTag("Player"))
        {
            uiScript.DissappearingText();
            playerIsInside = false;
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if(playerIsInside && Input.GetKeyDown(KeyCode.E) && interactable)
        {
            showerNeedle.preferredTemp = Random.Range(2.8f, 4.6f);
            showerNeedle.Move = true;
            playerMovement.enabled = false;
            lookingAround.enabled = false;
            indicator.transform.position = new Vector3(showerNeedle.preferredTemp, indicator.transform.position.y, indicator.transform.position.z);
            uiScript.DissappearingText();
            miniGameOn = true;
            interactable = false;
        }
        if (playerIsInside && Input.GetKeyDown(KeyCode.Mouse0) && miniGameOn)
        {
            showerNeedle.Move = false;
            playerMovement.enabled = true;
            lookingAround.enabled = true;
            miniGameOn = false;
        }
    }
}
