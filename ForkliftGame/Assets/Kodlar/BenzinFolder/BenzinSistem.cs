using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BenzinSistem : MonoBehaviour
{
    public float currentFuel = 100f;
    public Text fuelDisplay;
    public float baseInterval = 1f;
    float countDown;
    bool ForkliftMoving;

    public static BenzinSistem Bnz;
    void Start()
    {
        ForkliftMoving = true;
        countDown = baseInterval;
        
    }

    // Update is called once per frame
    void Update()
    {
        if (ForkliftMoving)
        {
            if(countDown > 0)
            {
                countDown -= Time.deltaTime;
            }
            else
            {
                countDown = baseInterval;
                currentFuel -= 1f;
            }
        }
        fuelDisplay.text = "Fuel: " + currentFuel;
    }
    
}
