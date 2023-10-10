using UnityEngine;
using UnityEngine.Tilemaps;

public enum Tetromino
{//set the shapes of the pieces
    I,
    O,
    T,
    J,
    L,
    S,
    Z
}
[System.Serializable]
public struct TetrominoData
{//builds the tetromino
    public Tetromino tetromino;
    public Tile tile;
    public Vector2Int[] cells { get; private set; }
    public Vector2Int[,] wallKicks { get; private set; }

    public void Initialize()
    {
        this.cells = Data.Cells[this.tetromino];
        this.wallKicks = Data.WallKicks[this.tetromino];
    }

}