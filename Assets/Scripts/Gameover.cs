using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Gameover : MonoBehaviour
{
    
    public Text pointsText;

    public void Setup(int score) { 
        gameObject.SetActive(true);
        pointsText.text = score.ToString() + " Points";
        
                
    }
    
    public void RestartButton() {
        SceneManager.LoadScene("Tetris");
        Debug.Log("restart");

    }

    public void MainMenuButton() {
        SceneManager.LoadScene("MainMenu");
    }
    
}

