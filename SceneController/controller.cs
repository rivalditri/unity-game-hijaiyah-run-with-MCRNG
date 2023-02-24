using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class controller : MonoBehaviour
{
    public AudioSource sounds;
    // Start is called before the first frame update
    public void play(){
        SceneManager.LoadScene("worldScreen");
    }
    public void play2(){
        SceneManager.LoadScene("worldScreen2");
    }
    public void play3(){
        SceneManager.LoadScene("worldScreen3");
    }
    public void play4(){
        SceneManager.LoadScene("worldScreen4");
    }
    public void play5(){
        SceneManager.LoadScene("worldScreen5");
    }

    public void exit(){
        Application.Quit();
        sounds.Stop();
    }
}
