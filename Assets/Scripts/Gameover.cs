using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Gameover : MonoBehaviour
{
    public Board board; 
    public Text pointsText;

    public void Setup(int score) { 
        gameObject.SetActive(true);
        pointsText.text = score.ToString() + " Points";
        
    }
    
    public void RestartButton() {
        SceneManager.LoadScene("Tetris");

    }

    public void MainMenuButton() {
        SceneManager.LoadScene("MainMenu");
    }
    
}
