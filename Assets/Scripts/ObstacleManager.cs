using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleManager : MonoBehaviour
{
    public ObstacleData obstacleData;
    public GameObject obstaclePrefab; // Red Sphere Prefab
    public float yOffset = 1f; // To float above the tile

    private void Start()
    {
        Debug.Log("ObstacleManager is awake and ready to drop some spheres.");
        GenerateObstacles();
    }


    void GenerateObstacles()
    {
        for (int row = 0; row < 10; row++)
        {
            for (int col = 0; col < 10; col++)
            {
                if (obstacleData.IsObstacle(row, col))
                {
                    Vector3 pos = new Vector3(row * 1.1f, yOffset, col * 1.1f);
                    Instantiate(obstaclePrefab, pos, Quaternion.identity, this.transform);
                }
            }
        }
    }
}