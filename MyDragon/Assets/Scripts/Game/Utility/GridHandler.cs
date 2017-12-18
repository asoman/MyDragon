using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridHandler : MonoBehaviour {

    public int cellCount;
    private float cellSize;

    public GridHandler(float screenWidth = 150, int cellCount = 3)
    {
        this.cellCount = cellCount;
        cellSize = screenWidth / cellCount;
    }

	// Use this for initialization
	void Start () {
        Vector2 screenBounds = Camera.main.ScreenToWorldPoint(new Vector2(Screen.width, Screen.height));
        Vector2 screenOrigo = Camera.main.ScreenToWorldPoint(Vector2.zero);
        cellSize = (screenOrigo.x - screenBounds.x)/cellCount;
    }
	
    public Vector2 GetWorldCoordsOfCell(Vector2 cell)
    {
        return cell * cellSize;
    }
}
