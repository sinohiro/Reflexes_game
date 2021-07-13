using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Title : MonoBehaviour{
    private bool firstPush = false;

    public void PressMemory(){
        Debug.Log("Press Memory");
        if(!firstPush){
            Debug.Log("Go Next Scene");
            //次のシーンへスクリプト
            firstPush = true;
        }
    }
}
