using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charMove : MonoBehaviour
{
    public Animator anim;
    public float speed = 10;
    public float horizonSpeed = 10;

    void Start(){
        anim.SetBool("isRunning", false);
    }

    void Update()
    {
        //movement input
        if(winCheck.isWin){
            anim.SetBool("isVictory", true);
        }else{
            //vertical movement
            horizontalMove();
            //character movement
            transform.Translate(Vector3.forward * speed * Time.deltaTime * 1);
            //animating
            animateRun();
        }

        if(healthScript.healthText <= 0){
            animateFalse();
            Debug.Log("You Lose");
        }
    }

    void horizontalMove(){
        //move left
        if(Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow)){
            if(this.gameObject.transform.position.x > levelBoundary.leftSide){
                transform.Translate(Vector3.left * horizonSpeed * Time.deltaTime);
            }
        }
        //move right
        if(Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow)){
            if(this.gameObject.transform.position.x < levelBoundary.rightSide){
                transform.Translate(Vector3.right * horizonSpeed * Time.deltaTime);
            }
        }
    }

    void animateRun(){
        anim.SetBool("isRun", true);
        anim.SetBool("isHit", false);
    }

    void animateWin(){
        anim.SetBool("isVictory", true);
        Debug.Log("You Win");
    }

    void animateFalse(){
        anim.SetBool("isRun", false);
        anim.Play("Stumble Backwards");
        speed = 0;
        horizonSpeed = 0;
    }
}
