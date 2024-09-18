using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GamemanagerText : MonoBehaviour
{
    public TextMeshProUGUI text;
    //상황들의 리스트
    //대사모음집
    List<string[]> contexts = new List<string[]>();

    int actCount = 5; //상황의 개수
    int minTextCount = 3; //한 상황에 대한 최소 대사의 개수
    int maxTextCount = 8; //한 상황에 대한 최대 대사의 개수
    int actIndex=0; //현재 상황 인덱스
    int actTextIndex; //현재 상황에 대한 대사 인덱스



    //상황 a~e 배열을 넣을 리스트
    string[] actName = { "A", "B", "C", "D", "E" };

    private void Start()
    {
        //작성 이유?
        //->리스트에 actCount만큼 상황을 추가하기 위해

        //그럼 왜 actCount만큼 반복하는 가?
        //actCount = 상황의 개수
        for (int i = 0; i < actCount; i++)
        {
            //dialogue = 상황의 대사들

            //배열 길이를 랜덤으로 한 이유?
            //->대사가 없어서 임의의 대사를 만들기위해 랜덤으로 설정(대사 3~8개로 설정)

            //maxTextCount + 1 이유?(1을 더한 이유?)
            //Random.Range 정수형일때 최대값 포함x
            string[] dialogue = new string[Random.Range(minTextCount, maxTextCount + 1)];


            //대사의 초기화
            //arr.Length 번 반복 이유
            //arr.Length -> 대사의 길이

            //대사의 길이 언제 설정?
            //바로 위에서 함
            //Random.Range(minTextCount, maxTextCount + 1) -> 의미 길이 설정 //상황의 대사 개수
            //new string[상황의 대사 개수]; //현 상황의 길이
            for (int j = 0; j < dialogue.Length; j++)
            {
                //i번인덱스 상황의 j번인덱스 대사 설정
                //arr[j] -> j 대사
                //actName[i] -> i 상황

                //해당 상황의 대사들 넣어주기
                dialogue[j] = actName[i] + (j + 1);
            }
            //상황 추가하기
            contexts.Add(dialogue);
        }

    }

    public void BtClick()
    {
        //actIndex  contexts.count  contexts[actIndex].Length   actTextIndex
        //현재상황   상황의 개수      현재상황의 대사의 개수        대사 인덱스

        //마지막 상황에 마지막 대사를 출력 이후 라면       
        if (actIndex >= contexts.Count-1 && contexts[actIndex].Length <= actTextIndex)
        {// 마지막상황                       마지막 대사 
            
            //더이상 출력할 대사는 없다.
            text.text = "no more text";
            //함수 종료
            return;
        }


        //현 상황의 마지막 대사 출력 했다면
        if (contexts[actIndex].Length <= actTextIndex)
        {
            //다음 상황으로 넘기기
            actIndex++;
            //해당 상황의 처음으로 대사 설정
            actTextIndex = 0;

        }
        //현상황의 인덱스번 대사 출력
        text.text = contexts[actIndex][actTextIndex++];
    }
    //모든 상황이 다 끝났을때 "no more text"라고 text.text 설정하기
}