using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class quizScript : MonoBehaviour
{
    public static string quizDisplay;
    public string[] quiz;
    private TextMeshProUGUI quizText;
    public float timeleft;
    public float originaltime;
    private float random;
    private float xo;
    public GameObject[] hijaiyah;
    // Start is called before the first frame update
    void Start()
    {
        quiz = new string[hijaiyah.Length];
        quizText = GetComponent<TextMeshProUGUI>();
        for(int i = 0; i < hijaiyah.Length; i++){
            quiz[i] = hijaiyah[i].name;
        }
        

        xo = Time.deltaTime *100;

        quizDisplay = quiz[0];
    }

    // Update is called once per frame
    void Update()
    {
        timeleft -= Time.deltaTime;     //countdown timer
        // xo = Time.deltaTime * 100;
        
        if (timeleft <= 0)
        {
            xo = Time.deltaTime * 100;
            quizDisplay = quiz[McRNG(xo)];;
    
            timeleft = originaltime;
        }
        quizText.text = quizDisplay;
    }

    //rumus mcRNG 
    //xi = (xo * a) mod m
    //xo = seed -> diambil dari waktu
    //A = multiplier -> 19
    //m = modulus -> 6
    int McRNG(float xo){
        random = xo * 19 % 6;
        xo = random;

        Debug.Log("random number = " + (int)random);
        return (int)random;
    }
}
