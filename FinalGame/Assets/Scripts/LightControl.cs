using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;

public class LightControl : MonoBehaviour
{


    public float remainTime;
    public float startingTime;

    public bool timeUp;

    void Start()
    {


        timeUp = false;

        remainTime = 60f;
        startingTime = 60f;


    }


    void Update()
    {
        if (remainTime > 0)
        {
            remainTime -= Time.deltaTime;
        }
        else
        {
            timeUp = true;
            //setgameOver = true
        }

        GetComponent<Light2D>().intensity = (remainTime / startingTime) + .2f;



        GetComponent<Light2D>().pointLightInnerRadius = ((remainTime / startingTime) * 2) + .1f;
        GetComponent<Light2D>().pointLightOuterRadius = ((remainTime / startingTime) * 3) + .5f;
    }
}
