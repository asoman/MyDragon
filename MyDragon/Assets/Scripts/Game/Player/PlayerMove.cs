using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {

    private Vector2 currentGridPos;

    private void OnEnable()
    {
        currentGridPos = new Vector2(0, 0);
        SwipeEventListener.Swipe += DoMove;
    }

    private void OnDisable()
    {
        SwipeEventListener.Swipe -= DoMove;
    }

    private void DoMove(Vector2 gridMove)
    {
        currentGridPos += gridMove;
        currentGridPos.x = Mathf.Clamp(currentGridPos.x, -1, 1);
        currentGridPos.y = Mathf.Clamp(currentGridPos.y, -1, 1);
    }
}
