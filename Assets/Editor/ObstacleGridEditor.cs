using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ObstacleGridEditor : EditorWindow
{
    public ObstacleData obstacleData;

    [MenuItem("Tools/Obstacle Grid Editor")]

    public static void ShowWindow()
    {
        GetWindow<ObstacleGridEditor>("ObstacleGridEditor");
    }

    private void OnGUI()
    {
        GUILayout.Label("Obstacle Grid Editor", EditorStyles.boldLabel);

        obstacleData = (ObstacleData)EditorGUILayout.ObjectField("Obstacle Data", obstacleData, typeof(ObstacleData) , false);

        if (obstacleData == null)
        {
            EditorGUILayout.HelpBox("Assign an ObstacleData ScriptableObject.", MessageType.Info);
            return;
        }

        for (int row = 0; row < 10; row++)
        {
            GUILayout.BeginHorizontal();
            for(int col = 0; col < 10; col++)
            {
                int index = row * 10 + col;
                obstacleData.obstacleGrid[index] = GUILayout.Toggle(obstacleData.obstacleGrid[index] , GUIContent.none ,GUILayout.Width(20) , GUILayout.Height(20));
                
            }
            GUILayout.EndHorizontal();
        }

        if (GUILayout.Button("Save"))
        {
            EditorUtility.SetDirty(obstacleData);
            AssetDatabase.SaveAssets();
        }
    }


}
