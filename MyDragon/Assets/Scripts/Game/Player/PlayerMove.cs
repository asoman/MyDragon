using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {

    public float speed = 5.0f;

    private Vector2 currentGridPos;
    private Vector3 currentWorldPos;
    private GridHandler grid;

    private void OnEnable()
    {
        grid = GameObject.Find("GameField").GetComponent<GridHandler>();
        currentGridPos = new Vector2(0, 0);
        SwipeEventListener.Swipe += DoMove;
    }

    private void OnDisable()
    {
        SwipeEventListener.Swipe -= DoMove;
    }

    private void Update()
    {
        if((transform.position-currentWorldPos).magnitude > 0.1f)
        {
            transform.position = Vector3.Lerp(transform.position, currentWorldPos, Time.deltaTime * speed);
        }
    }

    private void DoMove(Vector2 gridMove)
    {
        currentGridPos += gridMove;
        currentGridPos.x = Mathf.Clamp(currentGridPos.x, -1, 1);
        currentGridPos.y = Mathf.Clamp(currentGridPos.y, -1, 1);

        currentWorldPos = grid.GetWorldCoordsOfCell(currentGridPos);

    }
}
