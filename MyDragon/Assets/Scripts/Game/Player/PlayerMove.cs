using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour {

    private void OnEnable()
    {
        SwipeEventListener.Swipe += DoMove;
    }

    private void OnDisable()
    {
        SwipeEventListener.Swipe -= DoMove;
    }

    private void DoMove(int x, int y)
    {
        Debug.Log(x + y);
    }
}
