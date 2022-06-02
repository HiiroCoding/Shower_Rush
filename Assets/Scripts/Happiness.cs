using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Happiness : MonoBehaviour
{
    public int maxHappiness = 100;
    public int currentHappiness;

    public HappinessBar happinessbar;

    // Start is called before the first frame update
    void Start()
    {
        currentHappiness = 0;
    }

    // Update is called once per frame
    void Update()
    {
        happinessbar.SetHappiness(currentHappiness);
    }
}
