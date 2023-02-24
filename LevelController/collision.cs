using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour
{
    public static bool Answer = true;
    public AudioSource sounds;
    // Update is called once per frame
    void OnTriggerEnter(Collider other){
        string jawaban = this.gameObject.name;
        string soal = quizScript.quizDisplay;

        if(soal == jawaban || soal+"(Clone)" == jawaban || jawaban == "hijaiyah")
        {
            this.gameObject.SetActive(false);
            PoinControl.poin += 10;
            sounds.Play();
            Answer = true;
        }else{
            healthScript.healthText -= 1;
            this.gameObject.SetActive(false);
        }

    }

}
