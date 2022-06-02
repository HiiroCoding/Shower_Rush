using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BrushingScript : MonoBehaviour
{
    public int number = 2;

    public GameObject brushingBar;
    public GameObject toothBrush;

    public SinkGame sinkGame;
    public PlayerMovement playerMovement;
    public Lookingaround lookingAround;
    public Brush brush;
    public Happiness happiness;

    public float circleFillAmount;

    public bool shouldBrushMove;
    public bool left;
    public bool right;
    public bool runOnce;
    // Start is called before the first frame update
    void Start()
    {
        circleFillAmount = 0;
        left = true;
        right = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (shouldBrushMove && circleFillAmount <= 100)
        {
            if(!runOnce)
            {
                brush.SetChild();
                brush.TransformNew();
                runOnce = true;
                brush.brushmoving = true;
            }
            if(Input.GetAxis("Mouse X") < -number && left)
            {
                brush.MoveLeft();
                Debug.Log("Mouse moved left");
                circleFillAmount += 2;
                left = false;
                right = true;
            }
            if(Input.GetAxis("Mouse X") > number && right)
            {
                brush.MoveRight();
                Debug.Log("Mouse Moved Right");
                circleFillAmount += 2;
                right = false;
                left = true;
            }
        }
        else if(shouldBrushMove && circleFillAmount > 100)
        {
            brush.StopMotion();
            playerMovement.enabled = true;
            lookingAround.enabled = true;
            Debug.Log("Done!");
            if (runOnce)
            {
                brush.RemoveChild();
                brush.TransformReset();
                runOnce = false;
                brush.brushmoving = false;
            }
            shouldBrushMove = false;
            happiness.currentHappiness += 15;
        }
        brushingBar.GetComponent<Image>().fillAmount = circleFillAmount / 100;
    }
}
