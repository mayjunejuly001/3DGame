using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileInfo : MonoBehaviour
{
    public Cell Cell { get; private set; }

    public void Init(Vector2Int position, bool isWalkable)
    {
        Cell = new Cell(position);
        Cell.isWalkable = isWalkable;
    }

    private void Start()
    {
        Debug.Log($"Hello! I'm tile at ({Cell.position.x}, {Cell.position.y}) – I know my place in life.");
        //Debug.Log($"Hello! I'm tile at ({row}, {column}) – I know my place in life.");
    }

}

[System.Serializable]
public class Cell
{
    public Vector2Int position;
    public int fCost = int.MaxValue;
    public int gCost = int.MaxValue;
    public int hCost = int.MaxValue;

    public bool isWalkable = true;

    public Cell(Vector2Int pos)
    {
        position = pos;
    }
}
