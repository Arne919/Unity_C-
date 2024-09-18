using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Queen : ChampionInfo
{
    public Queen(string name, int lv, float maxHp) : base(name, lv, maxHp)
    {
        skills[0] = new LoLSkill("�Ǹ� ����", 4, 6);
        skills[1] = new LoLSkill("������ ����", 6, 5);
        skills[2] = new LoLSkill("���� ����", 3, 7);
        skills[3] = new LoLSkill("�Ĺ� ����", 30, 15);
    }

    public override void Q()
    {
        Debug.Log("�Ǹ� ����");
    }
    public override void W()
    {
        Debug.Log("������ ����");
    }
    public override void E()
    {
        Debug.Log("���� ����");
    }
    public override void R()
    {
        Debug.Log("�Ĺ� ����");
    }
}