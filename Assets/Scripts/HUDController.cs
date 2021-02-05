using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HUDController : MonoBehaviour
{
    public static float timeScale = 2;

    void Start()
    {
        SliderUpdated(1);
    }


    void Update()
    {
        
    }

    public void SliderUpdated(float amt)
    {
        timeScale = amt;
    }


}
