using UnityEngine;
using UnityEngine.SceneManagement;

public class Gameover : MonoBehaviour
{
    //public Board board { get; private set; }
    
    public void Setup(int score) { 
        gameObject.SetActive(true);
        //this.tilemap.ClearAllTiles(); this should wipe all pieces on the board but i've had issues will pulling from Board.cs
    }
    
    public void RestartButton() {
        SceneManager.LoadScene("Tetris");

    }
    
}
