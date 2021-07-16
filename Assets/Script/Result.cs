using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;  // 追加しましょう

public class Result : MonoBehaviour{
    Alert Alertscript;
    public Text ResultText; // Textオブジェクト
    private bool firstPush = false;

    void Start(){
        Alertscript = GameObject.Find("Image").GetComponent<Alert>(); //GetComponentはスクリプト名
        Debug.Log(Alertscript.result);
    }

    // Update is called once per frame
    void Update(){
        // テキストの表示を入れ替える
        if(Alertscript.result == -1){
            ResultText.text = "お手つきはいけません!!";
        }else{
            ResultText.text = Alertscript.result + "ms";
        }

        if (Input.GetKeyDown(KeyCode.Space)){
            PressMemory();
        }
    }

    public void PressMemory(){
        Debug.Log("Press Memory");
        if(!firstPush){
            Debug.Log("Go Next Scene");
            firstPush = true;
            //次のシーンへスクリプト
            SceneManager.LoadScene("titleScene");
        }
    }
}
