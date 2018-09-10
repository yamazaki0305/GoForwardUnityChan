using System;
using System.Linq;
using System.Text;
using System.IO;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class CubeController : MonoBehaviour
{

    // キューブの移動速度
    private float speed = -0.2f;

    // 消滅位置
    private float deadLine = -10;

    // Use this for initialization
    void Start()
    {
        //ボリュームを0にする
        //GetComponent<AudioSource>().volume = 0;
    }

    // Update is called once per frame
    void Update()
    {
        // キューブを移動させる
        transform.Translate(this.speed, 0, 0);

        // 画面外に出たら破棄する
        if (transform.position.x < this.deadLine)
        {
            Destroy(gameObject);
        }
    }

    //他のオブジェクトと接触した場合の処理
    void OnCollisionEnter2D(Collision2D other)
    {
        Debug.Log("当たり判定");
        //障害物に衝突した場合（追加）
        if (other.gameObject.tag == "BlockTag")
        {
            Debug.Log("音声再生");
            GetComponent<AudioSource>().Play();

        }
        
    }
}