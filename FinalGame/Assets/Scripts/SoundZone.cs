using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundZone : MonoBehaviour
{
    // Create a variable to keep track of whether the trigger zone is active
    private AudioSource soulSound;
    bool active = true;
    
    private void Start()
    {
        soulSound = GetComponent<AudioSource>();
    }
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        // if the trigger zone is active...
        if (active && collision.gameObject.tag == "Player")
        {
            // deactivate the trigger zone
            active = false;
            
            // Adds 1 to the score when the player enters the trigger zone
            gameObject.SetActive(true);

            soulSound.Play();
        }
    }
}
