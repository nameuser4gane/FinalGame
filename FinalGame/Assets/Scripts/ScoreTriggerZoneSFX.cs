using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreTriggerZoneSFX : MonoBehaviour
{
    public AudioClip soulSound;
    
    private AudioSource audioSource;
    
    void Start()
    {
        // Get the AudioSource component attached to this GameObject
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            // If there's no AudioSource component, add one
            audioSource = gameObject.AddComponent<AudioSource>();
        }
    }
    
    // Called when another GameObject enters the trigger zone
    void OnTriggerEnter(Collider other)
    {
        // Check if the GameObject entering the trigger zone has a specific tag
        if (other.CompareTag("Player"))
        {
            // Play the sound effect
            audioSource.PlayOneShot(soulSound);
        }
    }
}
