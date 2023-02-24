using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class healthScript : MonoBehaviour
{
    public static int healthText;
    private TextMeshProUGUI healthDisplay;
    
    void Start(){
        healthDisplay = GetComponent<TextMeshProUGUI>();
        healthText = 3;
    }

    void Update(){
        healthDisplay.text = healthText.ToString();
    }
}
