using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TileSpawner : MonoBehaviour
{
    public GameObject tilePrefab;
    public int rows = 10;
    public int cols = 10;
    public float spacing = 1f;

    private void Start()
    {
       spawnGrid();
    }

    private void spawnGrid()
    {
        for (int x = 0; x < rows; x++)
        {
            for( int z  = 0; z < cols; z++)
            {
                Vector3 position = new Vector3(x * spacing, 0 , z * spacing);
                GameObject tile = Instantiate(tilePrefab, position, Quaternion.identity);
                tile.name = $"Tile_{x}_{z}";

                TileInfo tileInfo = tile.GetComponent<TileInfo>();
                if (tileInfo != null)
                {
                    tileInfo.row = x;
                    tileInfo.column = z;

                }
                else
                {
                    Debug.Log("No information found");
                }

            }
        }
    }
}
