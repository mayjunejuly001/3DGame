
using UnityEngine;

[CreateAssetMenu(fileName ="ObstacleData" , menuName = "Grid/ObstacleData")]
public class ObstacleData : ScriptableObject
{
    public bool[] obstacleGrid = new bool[100];

    public bool IsObstacle(int row , int col)
    {
        return obstacleGrid[row * 10 + col];
    }

    public void SetObstacle(int row , int col , bool value)
    {
        obstacleGrid[row * 10 + col] = value;
    }
}
