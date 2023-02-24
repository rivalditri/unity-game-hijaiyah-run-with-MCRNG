using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PoinControl : MonoBehaviour
{
    public static int poin;
    private TextMeshProUGUI poinText;

    void Start(){
        poinText = GetComponent<TextMeshProUGUI>();
        poin = 0;
    }
    // Update is called once per frame
    void Update()
    {
        poinText.text = "" + poin;
    }
}
