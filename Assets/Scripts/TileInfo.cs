using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileInfo : MonoBehaviour
{
    public int row;
    public int column;

    private void Start()
    {
        Debug.Log($"Hello! I'm tile at ({row}, {column}) – I know my place in life.");
    }

}
