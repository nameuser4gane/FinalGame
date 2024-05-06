using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SafeZone : MonoBehaviour
{
    //bool active = true;
    
    public float time = 10;

    //public AudioClip triggerSound;

    public float delay = 2f;

    public LightControl remainTime;

    //private AudioSource playerAudio;

    private void OnTriggerStay2D(Collider2D collision)
    {
        //playerAudio = GetComponent<AudioSource>();
        if (collision.gameObject.tag == "Player")
        {
            LightControl lightControl = collision.gameObject.GetComponent<LightControl>();

           // active = false;

            //playerAudio.PlayOneShot(triggerSound, 1.0f);

            remainTime.AddTime(time);

        }
    }
}
