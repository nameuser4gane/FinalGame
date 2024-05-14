using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoulCollector : MonoBehaviour

{
    [SerializeField] private AudioSource collectionSoundEffect;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collectionSoundEffect != null && collectionSoundEffect.enabled)
                {
                    collectionSoundEffect.Play();
                }
    }
}
