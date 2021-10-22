using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;  // 追加しましょう

public class Score : MonoBehaviour{
    Alert Alertscript;
    public Text ScoreText1; // Textオブジェクト
    public Text ScoreText2;
    public Text ScoreText3;
    public Text ScoreTexthi;
    private bool firstPush = false;

    void Start(){
        //Alertscript = GameObject.Find("alert_Image").GetComponent<Alert>(); //GetComponentはスクリプト名
        Debug.Log(Alert.result);
    }

    // Update is called once per frame
    void Update(){
        // テキストの表示を入れ替える
        ScoreText1.text = PlayerPrefs.GetInt( "ScoreText1") + "ms";
        ScoreText2.text = PlayerPrefs.GetInt( "ScoreText2") + "ms";
        ScoreText3.text = PlayerPrefs.GetInt( "ScoreText3") + "ms";
        ScoreTexthi.text = PlayerPrefs.GetInt( "ScoreTextHi") + "ms";

        if (Input.GetKeyDown(KeyCode.Space)){
            PressMemory();
        }
    }

    public void PressMemory(){
        Debug.Log("Press Memory");
        if(!firstPush){
            Debug.Log("Go Next Scene");
            firstPush = true;
            //Alert.result = -1;
            //Alert.otetuki_count = 0;
            //次のシーンへスクリプト
            SceneManager.LoadScene("titleScene");
        }
    }
}
