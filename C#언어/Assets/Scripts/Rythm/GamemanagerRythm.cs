using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GamemanagerRythm : MonoBehaviour
{

    public GameObject original;
    float speed = 0;
    public float spawntime = 0.5f;

    public GameObject[] judgementLineArr;

    public static GamemanagerRythm instance; //this
    public TextMeshPro scoreText;
    public int score = 0;
    public void SetScore(int _score) //
    {
        score += _score;
        scoreText.text = score.ToString();
    }


    public AudioSource audioSource;
    public void EffectPlay()
    {
        audioSource.Play();
    }


    void Start()
    {
        instance = this;
    }



    void Update()
    {

        //0.5초 마다 노트생산하게 만들기
        speed += Time.deltaTime;

        if (speed >= spawntime)
        {
            GameObject temp = GameObject.Instantiate(original);
            int index = Random.Range(0, judgementLineArr.Length);

            temp.transform.position = new Vector3(judgementLineArr[index].transform.position.x, 5.7f, 0);
            speed = 0;


        }
        
    }
}


