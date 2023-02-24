using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameControl : MonoBehaviour
{
    public GameObject spawner;
    public GameObject quiz;
    public GameObject victory;
    public GameObject over;

    // Update is called once per frame
    void Update()
    {
        if(winCheck.isWin == true){
            victory.SetActive(true);
        }
        if(healthScript.healthText <=0){
            spawner.SetActive(false);
            quiz.SetActive(false);
            over.SetActive(true);
        }
        if(Input.GetKeyDown(KeyCode.Space)){
            Debug.Log("pause");
        }
    }

}
