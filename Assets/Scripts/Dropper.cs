using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    //生成されるフルーツを格納する配列を作成
    [SerializeField] private GameObject[] fruitsPrefabs;



    //フルーツを落とすオブジェクトの移動速度
    float speed = 0.05f;

    float defaultPos;
    [SerializeField]
    AudioClip sound;
    AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        //Componentを取得
        audioSource = GetComponent<AudioSource>();
        defaultPos = transform.position.x;
        Pop();
    }

    // Update is called once per frame
    void Update()
    {
        float x = transform.position.x + speed;
        if (x > defaultPos + 5.0f || x<defaultPos -5.0f)
            {
            speed *= -1;
        }
        transform.position = new Vector3(x, transform.position.y,
            transform.position.z);
    }
            
       //ここに移動のプログラムを書きましょう
    
    public void Pop()
    {
        //変数の中にランダムな数字を格納しておく
        int randomlndex = UnityEngine.Random.Range(0, fruitsPrefabs.Length);
        //フルーツの生成
        Instantiate(fruitsPrefabs[randomlndex], transform.position, Quaternion.identity, transform);
        audioSource.PlayOneShot(sound);
    }
}