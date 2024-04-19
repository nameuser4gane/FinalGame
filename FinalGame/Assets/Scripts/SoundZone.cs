using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundZone : MonoBehaviour
{
    // Add an AudioClip variable to hold the sound effect
    public AudioClip soulSound;

    // Create a variable to keep track of whether the trigger zone is active
    private bool active = true;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // if the trigger zone is active...
        if (active && collision.gameObject.tag == "Player")
        {
            // Play the sound effect
            AudioSource.PlayClipAtPoint(soulSound, transform.position);

            // Deactivate the trigger zone
            active = false;

            // Deactivate the GameObject
            gameObject.SetActive(false);
        }
    }
}
