using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dong : MonoBehaviour
{
    [SerializeField] float speed = 3f;

    //Vector3 startPos;
    //Vector3 endPos;

    //[SerializeField] float distance = 3;
    //float t = 0;

    ////T값이 증가해야한다면 true
    ////T값이 감소해야한다면 false

    ////방향
    //int tDir = 1;

    //private void Start()
    //{
    //    startPos = transform.position;
    //    endPos = transform.position + Vector3.up * distance;
    //}

    // Update is called once per frame
    void Update()
    {
        //this.transform.position += Vector3.down * Time.deltaTime * speed;

        //t가 범위밖을 벗어나면 증가하고 있으면 감소하고, 감소하고 있으면 증가하기
        //if (t > 1)
        //{
        //    tDir = -1;
        //}
        //else if (t < 0) 
        //{
        //    tDir = 1;        
        //}

        //t += Time.deltaTime * speed + tDir;

        //t값이 0 ~ 1 찍고 0으로 다시 감소하도록
        //1초에 speed만큼 t증가
        //speed t값 증가 속도

        //시작지점과 끝 지점 (0~1 ~0~1 반복하는) t
        //transform.position = Vector3.Lerp(startPos, endPos, t);


    }
}
