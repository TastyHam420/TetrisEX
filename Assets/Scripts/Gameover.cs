using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Gameover : MonoBehaviour
{
    public Board board; 
    public Text pointsText;
    public Text boardText;

    public void Setup(int score) { 
        gameObject.SetActive(true);
        pointsText.text = score.ToString() + " Points";
        boardText.text = score.ToString() + " Points"; //may need to move this to board.cs this only adds points once gameover triggers

        
    }
    
    public void RestartButton() {
        SceneManager.LoadScene("Tetris");

    }

    public void MainMenuButton() {
        SceneManager.LoadScene("MainMenu");
    }
    
}

