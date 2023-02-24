using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnerHijaiyah : MonoBehaviour
{
    public GameObject player;
    public GameObject[] hijaiyah;
    public float timeleft;
    public float originaltime;
    // Update is called once per frame

    void Update(){
        if(winCheck.isWin == false){
            timeleft -= Time.deltaTime;     //countdown timer
            if (timeleft <= 0)              
            {
                spawnHijaiyah();            //spawn hijaiyah
                timeleft = originaltime;    //reset timer
            }
        }
    }

    void spawnHijaiyah(){
        Vector3 position = player.transform.position;   //get player position
        position.z = position.z + 30;                   //spawn hijaiyah 30 unit ahead of player
        position.x = Random.Range(71f,98f);             //randomize x position
        position.y = 0;                                 //set y position to 0
        Vector3 fixedPosition = new Vector3(position.x, position.y, position.z);    //create new vector3
        Instantiate(hijaiyah[Random.Range(0,hijaiyah.Length)], fixedPosition, Quaternion.identity);         //spawn hijaiyah
    }
}
