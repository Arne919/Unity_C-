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

    ////T���� �����ؾ��Ѵٸ� true
    ////T���� �����ؾ��Ѵٸ� false

    ////����
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

        //t�� �������� ����� �����ϰ� ������ �����ϰ�, �����ϰ� ������ �����ϱ�
        //if (t > 1)
        //{
        //    tDir = -1;
        //}
        //else if (t < 0) 
        //{
        //    tDir = 1;        
        //}

        //t += Time.deltaTime * speed + tDir;

        //t���� 0 ~ 1 ��� 0���� �ٽ� �����ϵ���
        //1�ʿ� speed��ŭ t����
        //speed t�� ���� �ӵ�

        //���������� �� ���� (0~1 ~0~1 �ݺ��ϴ�) t
        //transform.position = Vector3.Lerp(startPos, endPos, t);


    }
}
