using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShoweNeedle : MonoBehaviour
{
    public int speed = 2;
    public Vector3 maxValue;
    public Vector3 minValue;
    public float posX = 2.6f;
    public static float dis;

    public bool Move;
    bool check;

    public float preferredTemp;

    public Happiness happiness;
    int IncH;

    // Update is called once per frame
    void Update()
    {
       if(Move)
        {
            Vector3 pos = new Vector3(posX + Mathf.PingPong(speed * Time.time, 2.4f), 5.125f, 7.9f);
            transform.position = pos;
            check = true;
        }

       if(!Move && check)
        {
            if(transform.position.x > preferredTemp)
                dis = transform.position.x - preferredTemp;
            else
                dis = preferredTemp - transform.position.x;
            
            if (dis > 1.0f)
            {
                IncH = -10;
            }
            else if (dis >= 0.5f && dis <= 1.0f)
            {
                IncH = 5;
            }
            else if (dis >= 0.3f && dis <= 0.5f)
            {
                IncH = 10;
            }
            else if (dis >= 0.2f && dis <= 0.3f)
            {
                IncH = 12;
            }
            else if (dis >= 0.1f && dis <= 0.2f)
            {
                IncH = 15;
            }
            else if (dis >= 0.05f && dis <= 0.1f)
            {
                IncH = 17;
            }
            else if (dis < 0.05f)
            {
                IncH = 20;
            }

            happiness.currentHappiness += IncH;
            check = false;
        }

    }
}
