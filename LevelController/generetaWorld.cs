using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class generetaWorld : MonoBehaviour
{
    public GameObject world;
    private int zpos = 1000;
    private float timeleft = 90f;
    private float originalTime = 90f;

    // Update is called once per frame
    void Update()
    {
            timeleft -= Time.deltaTime;
            if (timeleft < 0)
            {
                spawn();
                timeleft = originalTime;
            }
    }

    void spawn()
    {
        Instantiate(world, new Vector3(0, 0, zpos), Quaternion.identity);
        Debug.Log("World Created");
        zpos += 1000;
    }
}
