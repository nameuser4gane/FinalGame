using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.Rendering.Universal;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LightControl : MonoBehaviour
{


    public float remainTime;
    public float startingTime;

    public bool timeUp;


    public int sceneBuildIndex;

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
            print("Switching Scene to " + sceneBuildIndex);
            SceneManager.LoadScene(sceneBuildIndex, LoadSceneMode.Single);


            //setgameOver = true
        }

        GetComponent<Light2D>().intensity = (remainTime / startingTime) + .2f;



        GetComponent<Light2D>().pointLightInnerRadius = ((remainTime / startingTime) * 2) + .1f;
        GetComponent<Light2D>().pointLightOuterRadius = ((remainTime / startingTime) * 4) + .5f;



    }

    public void AddTime(float time)
    {
        if (remainTime < 60)
        {
            remainTime += time;
            
        }
    }
}