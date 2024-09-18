using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GamemanagerText : MonoBehaviour
{
    public TextMeshProUGUI text;
    //��Ȳ���� ����Ʈ
    //��������
    List<string[]> contexts = new List<string[]>();

    int actCount = 5; //��Ȳ�� ����
    int minTextCount = 3; //�� ��Ȳ�� ���� �ּ� ����� ����
    int maxTextCount = 8; //�� ��Ȳ�� ���� �ִ� ����� ����
    int actIndex=0; //���� ��Ȳ �ε���
    int actTextIndex; //���� ��Ȳ�� ���� ��� �ε���



    //��Ȳ a~e �迭�� ���� ����Ʈ
    string[] actName = { "A", "B", "C", "D", "E" };

    private void Start()
    {
        //�ۼ� ����?
        //->����Ʈ�� actCount��ŭ ��Ȳ�� �߰��ϱ� ����

        //�׷� �� actCount��ŭ �ݺ��ϴ� ��?
        //actCount = ��Ȳ�� ����
        for (int i = 0; i < actCount; i++)
        {
            //dialogue = ��Ȳ�� ����

            //�迭 ���̸� �������� �� ����?
            //->��簡 ��� ������ ��縦 ��������� �������� ����(��� 3~8���� ����)

            //maxTextCount + 1 ����?(1�� ���� ����?)
            //Random.Range �������϶� �ִ밪 ����x
            string[] dialogue = new string[Random.Range(minTextCount, maxTextCount + 1)];


            //����� �ʱ�ȭ
            //arr.Length �� �ݺ� ����
            //arr.Length -> ����� ����

            //����� ���� ���� ����?
            //�ٷ� ������ ��
            //Random.Range(minTextCount, maxTextCount + 1) -> �ǹ� ���� ���� //��Ȳ�� ��� ����
            //new string[��Ȳ�� ��� ����]; //�� ��Ȳ�� ����
            for (int j = 0; j < dialogue.Length; j++)
            {
                //i���ε��� ��Ȳ�� j���ε��� ��� ����
                //arr[j] -> j ���
                //actName[i] -> i ��Ȳ

                //�ش� ��Ȳ�� ���� �־��ֱ�
                dialogue[j] = actName[i] + (j + 1);
            }
            //��Ȳ �߰��ϱ�
            contexts.Add(dialogue);
        }

    }

    public void BtClick()
    {
        //actIndex  contexts.count  contexts[actIndex].Length   actTextIndex
        //�����Ȳ   ��Ȳ�� ����      �����Ȳ�� ����� ����        ��� �ε���

        //������ ��Ȳ�� ������ ��縦 ��� ���� ���       
        if (actIndex >= contexts.Count-1 && contexts[actIndex].Length <= actTextIndex)
        {// ��������Ȳ                       ������ ��� 
            
            //���̻� ����� ���� ����.
            text.text = "no more text";
            //�Լ� ����
            return;
        }


        //�� ��Ȳ�� ������ ��� ��� �ߴٸ�
        if (contexts[actIndex].Length <= actTextIndex)
        {
            //���� ��Ȳ���� �ѱ��
            actIndex++;
            //�ش� ��Ȳ�� ó������ ��� ����
            actTextIndex = 0;

        }
        //����Ȳ�� �ε����� ��� ���
        text.text = contexts[actIndex][actTextIndex++];
    }
    //��� ��Ȳ�� �� �������� "no more text"��� text.text �����ϱ�
}