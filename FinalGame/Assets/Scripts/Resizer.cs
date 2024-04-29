using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Resizer : MonoBehaviour
{
    public float scale = 1.00f;



    void Update()
    {
        scale -= 0.001f;
        transform.localScale = new Vector2(scale, scale);
        if (scale <= 0.05f)
            SceneManager.LoadScene("GameOverScene");
    }
}
