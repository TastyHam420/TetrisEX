using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DifficultyManager : MonoBehaviour
{
    public float easyStepDelay = 1.0f;
    public float mediumStepDelay = 0.5f;
    public float hardStepDelay = 0.2f;

    private float currentStepDelay;

    private void Start()
    {
        // Set the initial difficulty to the default (easy)
        SetDifficulty(Difficulty.Easy);
    }

    public enum Difficulty
    {
        Easy,
        Medium,
        Hard
    }

    public void SetDifficulty(Difficulty difficulty)
    {
        // Update the step delay based on the selected difficulty
        switch (difficulty)
        {
            case Difficulty.Easy:
                currentStepDelay = easyStepDelay;
                break;
            case Difficulty.Medium:
                currentStepDelay = mediumStepDelay;
                break;
            case Difficulty.Hard:
                currentStepDelay = hardStepDelay;
                break;
        }

        // Apply the new step delay value
        UpdatePieceStepDelay();
    }

    //Manually defining difficulty
    public void CallSetDifficultyEasy()
    {
        SetDifficulty(Difficulty.Easy);
    }

    public void CallSetDifficultyMedium()
    {
        SetDifficulty(Difficulty.Medium);
    }

    public void CallSetDifficultyHard()
    {
        SetDifficulty(Difficulty.Hard);
    }

    private void UpdatePieceStepDelay()
    {
        // Reference to game object?
        Piece piece = FindObjectOfType<Piece>();

        if (piece != null)
        {
            piece.stepDelay = currentStepDelay;
            Debug.Log("Updated Tetromino step delay to: " + currentStepDelay);
        }
        else
        {
            Debug.LogError("Piece component not found!");
        }
    }
}