using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour
{
    bool inRange;
    public float range = 1f;
    public LayerMask player;
    public Happiness happiness;

    public bool Sink;
    public bool Shower;
    public bool Toilet;
    public bool bed;

    /*public bool locked;
    public PlayerMovement playerMovement;
    public Lookingaround lookingAround;*/

    // Update is called once per frame
    void Update()
    {
        inRange = Physics.CheckSphere(transform.position, range, player);

        if (inRange && Input.GetKeyDown(KeyCode.E) && Sink)
        {
            happiness.currentHappiness = happiness.currentHappiness + 20;
            print("You Just Brushed your teeth");
        }

        if (inRange && Input.GetKeyDown(KeyCode.E) && Toilet)
        {
            happiness.currentHappiness = happiness.currentHappiness + 20;
            print("Poooooooooop");
        }

        if (inRange && Input.GetKeyDown(KeyCode.E) && bed)
        {
            happiness.currentHappiness = happiness.currentHappiness + 40;
            print("ZzZzZzZzZzZz");
        }

        if (inRange && Input.GetKeyDown(KeyCode.E) && Shower)
        {
            happiness.currentHappiness = happiness.currentHappiness + 20;
            print("Waterfall");
        }

        /* To lock Movement and Camera.
        if(locked)
        {
            playerMovement.enabled = false;
            lookingAround.enabled = false;
        }*/
            
    }

    private void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, range);
    }
}
