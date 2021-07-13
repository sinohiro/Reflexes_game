using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class maingame : MonoBehaviour{
    [SerializeField] GameObject alert;
    public AudioClip shootSE;
    AudioSource audioSource;
    System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();

    void Start(){
        audioSource = GetComponent<AudioSource>();
        Invoke("Alert", Random.Range (2.0f, 10.0f));
    }

    void Alert(){
        alert.SetActive(true);
        audioSource.PlayOneShot(shootSE);
        sw.Start(); //時間計測開始
        if (Input.GetKeyDown(KeyCode.Space)){
            sw.Stop();
            Debug.Log(sw.ElapsedMilliseconds + "ms");
            //リザルトシーンへ
        }
    }
}
