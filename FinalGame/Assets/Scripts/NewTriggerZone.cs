using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewTriggerZone : MonoBehaviour
{
    // Create a variable to keep track of whether the trigger zone is active
    bool active = true;

    public AudioClip soulSound;
    private AudioSource zoneAudio;

    private void Start()
    {
        // Set reference variables to components
        zoneAudio = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (active && collision.gameObject.tag == "Player")
        {
            // Play collect sound when the player enters the trigger zone
            zoneAudio.PlayOneShot(soulSound, 1.0f);

            // Deactivates/hides trigger zone so player can only use once
            // SetActive(false) causes the object to leave the scene faster than the sound can play,
            // so for the time being a quick solution is to just make it invisible.
            active = false;
            //this.gameObject.SetActive(false);
            this.gameObject.GetComponent<Renderer>().material.color = new Color(250, 174, 90, 0f);

            // Add 1 to the score when the player enters the trigger zone
            ScoreManager.score++;

            // Start a coroutine to delay the destruction after playing the sound
            StartCoroutine(DestroyAfterSound());
        }
    }

    // Coroutine to delay destruction after playing the sound
    IEnumerator DestroyAfterSound()
    {
        // Wait for the duration of the audio clip
        yield return new WaitForSeconds(zoneAudio.clip.length);

        // Destroy the GameObject
        Destroy(gameObject);
    }
}
