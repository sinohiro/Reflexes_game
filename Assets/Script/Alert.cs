using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alert : MonoBehaviour{
    [SerializeField] GameObject alert;
    int otecount = 0;
    float seconds;
    bool alert_enable = false;
    public AudioClip shootSE;
    AudioSource audioSource;
    System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();

    void Start(){
        audioSource = GetComponent<AudioSource>();
    }

    void Update(){
        seconds += Time.deltaTime;
        if (seconds >= Random.Range(2.0f, 10.0f)){
            alert_enable = true;
            alert.SetActive(true);
            //audioSource.PlayOneShot(shootSE);
            sw.Start(); //時間計測開始
        }
        if (Input.GetKeyDown(KeyCode.Space)){
            sw.Stop();
            if (alert_enable){
                Debug.Log(sw.ElapsedMilliseconds + "ms");
                //リザルトシーンへ
            }
            else{
                otecount++;
                Debug.Log("お手つき!! x " + otecount);
                //ゲームオーバーシーンへ
            }
            sw.Reset();
            seconds = 0;
            alert.SetActive(false);
            alert_enable = false;
        }
    }
}
