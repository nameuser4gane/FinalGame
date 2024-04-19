using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewTriggerZone : MonoBehaviour
{
    // create a variable to keep track of
    // whether the trigger zone is active

    bool active = true;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        // if the trigger zone is active...
        if (active && collision.gameObject.tag == "Player")
        {
            // deactivate the trigger zone
            active = false;

            // Adds 1 to the score
            // when the player enters the trigger zone
            ScoreManager.score++;
            gameObject.SetActive(false);
        }
    }
}
