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
        Piece.DefaultStepDelay = 2f;
        SceneManager.LoadScene("Tetris");
    }

    public void midDifficulty(){
        Piece.DefaultStepDelay = 1f;
        SceneManager.LoadScene("Tetris");
    }

    public void hardDifficulty(){
        Piece.DefaultStepDelay = 0.5f;
        SceneManager.LoadScene("Tetris");
    }

}
