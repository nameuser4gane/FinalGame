using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    bool active = true;
    // Start is called before the first frame update
    public float time = 10;

    public AudioClip triggerSound;

    public float delay = 2f;

    public LightControl remainTime;

    private AudioSource playerAudio;


    private void OnTriggerEnter2D(Collider2D collision)
    {
      

        playerAudio = GetComponent<AudioSource>();
        if (active && collision.gameObject.tag == "Player")
        {
            LightControl lightControl = collision.gameObject.GetComponent<LightControl>();
            

            active = false;

            playerAudio.PlayOneShot(triggerSound, 1.0f);

            remainTime.AddTime(time);

            Destroy(gameObject, delay);
        }
    }

}
