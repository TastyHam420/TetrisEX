using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Difficulty : MonoBehaviour
{
    public Board board { get; private set; }
    
    public void easyDifficulty()
    {
        board.activePiece.stepDelay = 2f;
        SceneManager.LoadScene("Tetris");
        Debug.Log("easy");
    }

    public void midDifficulty(){
        board.activePiece.stepDelay = 1f;
        SceneManager.LoadScene("Tetris");
    }

    public void hardDifficulty(){
        board.activePiece.stepDelay = 0.5f;
        SceneManager.LoadScene("Tetris");
    }

}
