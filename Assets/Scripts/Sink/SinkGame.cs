using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SinkGame : MonoBehaviour
{
    public GameObject toothpasteBar;

    public float fillValueForT;

    public bool toothpasteIsBeingApplied = false;

    public BrushingScript brushingScript;

    // Start is called before the first frame update
    void Start()
    {
        fillValueForT = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButton(0) && toothpasteIsBeingApplied && fillValueForT <= 100)
        {
            fillValueForT++;
        }
        else if(Input.GetMouseButton(0) && toothpasteIsBeingApplied && fillValueForT > 100)
        {
            brushingScript.shouldBrushMove = true;
            toothpasteIsBeingApplied = false;
            Debug.Log("Brushing....");
        }
        toothpasteBar.GetComponent<Image>().fillAmount = fillValueForT / 100;
    }
}
