using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class winCheck : MonoBehaviour
{
    public static bool isWin = false;
    private int point;
    // Start is called before the first frame update
    void Start()
    {
        point = 0;
    }

    // Update is called once per frame
    void Update()
    {
        point = PoinControl.poin;
        if (point == 100)
        {
            isWin = true;
        }else
        {
            isWin = false;
        }
    }
}
