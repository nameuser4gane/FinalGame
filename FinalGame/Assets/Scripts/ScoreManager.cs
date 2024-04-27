using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ScoreManager : MonoBehaviour
{
    public static bool gameOver;
    public static bool won;
    public static int score;

    public TMP_Text textbox;
    public int soulsToCollect; // Number of souls to collect

    void Start()
    {
        gameOver = false;
        won = false;
        score = 0;
    }

    void Update()
    {
        if (!gameOver && score < soulsToCollect)
        {
            textbox.text = "Souls: " + score + "/" + soulsToCollect;
        }

        if (!gameOver && score == soulsToCollect)
        {
            textbox.text = "All souls freed!";
        }
    }
}
