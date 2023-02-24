using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levelBoundary : MonoBehaviour
{
    public static float leftSide = 71f;
    public static float rightSide = 98f;
    public float internalleft;
    public float internalright;
    // Update is called once per frame
    void Update()
    {
        internalleft = leftSide;
        internalright = rightSide;
    }
}
