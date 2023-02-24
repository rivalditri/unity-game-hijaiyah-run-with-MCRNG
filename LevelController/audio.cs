using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audio : MonoBehaviour
{
    private bool Answer;
    public AudioSource sounds;
    // Update is called once per frame
    void OnTriggerEnter(Collider other){
        string jawaban = this.gameObject.name;
        string soal = quizScript.quizDisplay;

        if(soal == jawaban || soal+"(Clone)" == jawaban)
        {
            this.gameObject.SetActive(false);
            PoinControl.poin += 10;
            sounds.Play();
        }else{
            Debug.Log("salah");
        }

    }
}
