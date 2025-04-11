using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TileHoverDetection : MonoBehaviour
{
    public Camera cam;
    public TextMeshProUGUI tileInfoText;
    private TileInfo lastHoveredTile = null;

    private void Update()
    {
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit))
        {
            TileInfo tile = hit.collider.GetComponent<TileInfo>();

            if (tile != null)
            {
                if (tile != lastHoveredTile)
                {
                    tileInfoText.text = $"Tile Info : ({tile.row}, {tile.column})";
                    lastHoveredTile = tile;
                }
            }
            else
            {
                ClearHover();
            }
        }
        else
        {
            ClearHover();
        }
    }

    private void ClearHover()
    {
        if (lastHoveredTile != null)
        {
            tileInfoText.text = "No Tile Detected";
            lastHoveredTile = null;
        }
    }
}
