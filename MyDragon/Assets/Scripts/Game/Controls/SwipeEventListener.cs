using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Lean.Touch;


public class SwipeEventListener : MonoBehaviour
{

    public delegate void SwipeAction(Vector2 gridMove);
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
            Swipe(new Vector2(1,0));
        }

        if (swipe.x > Mathf.Abs(swipe.y))
        {
            Swipe(new Vector2(-1, 0));
        }

        if (swipe.y < -Mathf.Abs(swipe.x))
        {
            Swipe(new Vector2(0, 1));
        }

        if (swipe.y > Mathf.Abs(swipe.x))
        {
            Swipe(new Vector2(0, -1));
        }
    }
}
