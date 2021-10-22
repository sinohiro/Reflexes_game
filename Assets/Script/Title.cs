using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Title : MonoBehaviour{
    private bool firstPush = false;

    void Update(){
        if (Input.GetKeyDown(KeyCode.Space)){
            Press_spase_Memory();
        }
        if (Input.GetKeyDown(KeyCode.S)){
            Press_s_Memory();
        }
    }

    void Press_spase_Memory(){
        Debug.Log("Press Memory");
        if(!firstPush){
            Debug.Log("Go Next Scene");
            firstPush = true;
            //次のシーンへスクリプト
            SceneManager.LoadScene("alertScene");
        }
    }
    void Press_s_Memory(){
        Debug.Log("Press Memory");
        if(!firstPush){
            Debug.Log("Go score Scene");
            firstPush = true;
            //次のシーンへスクリプト
            SceneManager.LoadScene("scoreScene");
        }
    }
}
