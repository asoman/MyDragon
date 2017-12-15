using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Lean.Touch;


public class SwipeEventListener : MonoBehaviour
{

    public delegate void SwipeAction(int x, int y);
    public static event SwipeAction Swipe;

    void Start()
    {
        LeanTouch.OnFingerSwipe += OnFingerSwipe;
    }

    private void OnDisable()
    {
        LeanTouch.OnFingerSwipe -= OnFingerSwipe;
    }
    

    private void OnFingerSwipe(LeanFinger finger)
    {
        var swipe = finger.SwipeScreenDelta;

        if (swipe.x < -Mathf.Abs(swipe.y))
        {
            Swipe(-1, 0);
        }

        if (swipe.x > Mathf.Abs(swipe.y))
        {
            Swipe(1, 0);
        }

        if (swipe.y < -Mathf.Abs(swipe.x))
        {
            Swipe(0, -1);
        }

        if (swipe.y > Mathf.Abs(swipe.x))
        {
            Swipe(0, 1);
        }
    }
}
