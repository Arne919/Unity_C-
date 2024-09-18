using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class LoLGamemanager : MonoBehaviour
{
    //è�Ǿ� ����â
    [SerializeField] GameObject choice;
    //���� â
    [SerializeField] GameObject battle;
    //è�Ǿ� ����â����
    [SerializeField] TextMeshProUGUI choiceText;

    //public PopupWindow pw;

    [SerializeField] Champion me;
    [SerializeField] Champion enemy;

    Garen garen = new Garen("����", 1, 300);
    Teemo teemo = new Teemo("Ƽ��", 1, 200);
    Queen queen = new Queen("��", 1, 100);

    //�� ������ �����ΰ�?
    bool enemyChoice = false;

    /// <summary>
    /// è�Ǿ� ���ý�
    /// </summary>
    /// <param name="champ">������ è�Ǿ��� �ε���</param>
    public void ChampionChoice(int champ)
    {
        ChampionInfo temp = null;

        switch (champ)
        {
            case 0:
                temp = garen;
                break;
            case 1:
                temp = teemo;
                break;
            case 2:
                temp = queen;
                break;
        }

        if (enemyChoice) //�� è�Ǿ� �����Ҽ���?����
        {
            //�� è�Ǿ� ����
            enemy.champ = temp;
            choice.SetActive(false); //ȭ����ȯ
            battle.SetActive(true);
        }
        else //����
        {
            //�� è�Ǿ� ����
            me.champ = temp;
            choiceText.text = "���� è�Ǿ� ����";
            enemyChoice = true;
        }
    }


    // Update is called once per frame
    void Update()
    {
        if (!battle.activeSelf)
            return;

        // �ƹ���ų�̳� ����
        if (InputManager.instance.skillindex != -1)
        {
            me.UseSkill(InputManager.instance.skillindex);
        }
    }
}