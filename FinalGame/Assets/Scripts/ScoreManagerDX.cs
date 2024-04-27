using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class ScoreManagerDX : MonoBehaviour
{
    
    // notice public static variables
    // can be accessed from any script
    // but cannot be seen in the inspector
    public static bool gameOverDX;
    public static bool wonDX;
    public static int scoreDX;
    
    public TMP_Text textboxDX;
    
    // public int ScoreToWin;
    
    // Start is called before the first frame update
    void Start()
    {
        gameOverDX = false;
        wonDX = false;
        scoreDX = 0;
    }
    
    // Update is called once per frame
    void Update()
    {
        if (!gameOverDX && scoreDX < 7)
        {
            textboxDX.text = "Souls: " + scoreDX + "/7";
        }
        
        if (!gameOverDX && scoreDX == 7)
        {
            textboxDX.text = "All souls freed!";
        }
        
        if (scoreDX >= 7)
        {
            wonDX = true;
            gameOverDX = true;
        }
        
        if (gameOverDX)
        {
            if (wonDX)
            {
            }
            else
            {
            }
        }
    }
}
