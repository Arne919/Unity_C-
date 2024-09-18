using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class LoLGamemanager : MonoBehaviour
{
    //챔피언 선택창
    [SerializeField] GameObject choice;
    //전투 창
    [SerializeField] GameObject battle;
    //챔피언 선택창글자
    [SerializeField] TextMeshProUGUI choiceText;

    //public PopupWindow pw;

    [SerializeField] Champion me;
    [SerializeField] Champion enemy;

    Garen garen = new Garen("가렌", 1, 300);
    Teemo teemo = new Teemo("티모", 1, 200);
    Queen queen = new Queen("퀸", 1, 100);

    //적 선택할 순간인가?
    bool enemyChoice = false;

    /// <summary>
    /// 챔피언 선택시
    /// </summary>
    /// <param name="champ">선택한 챔피언의 인덱스</param>
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

        if (enemyChoice) //적 챔피언 선택할순간?ㅇㅇ
        {
            //적 챔피언 설정
            enemy.champ = temp;
            choice.SetActive(false); //화면전환
            battle.SetActive(true);
        }
        else //ㄴㄴ
        {
            //내 챔피언 설정
            me.champ = temp;
            choiceText.text = "상대방 챔피언 선택";
            enemyChoice = true;
        }
    }


    // Update is called once per frame
    void Update()
    {
        if (!battle.activeSelf)
            return;

        // 아무스킬이나 사용시
        if (InputManager.instance.skillindex != -1)
        {
            me.UseSkill(InputManager.instance.skillindex);
        }
    }
}