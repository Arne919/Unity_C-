using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Garen : ChampionInfo
{
    public Garen(string name, int lv, float maxHp) : base(name, lv, maxHp)
    {
        skills[0] = new LoLSkill("����Ÿ", 6, 3f);
        skills[1] = new LoLSkill("���", 2, 5f);
        skills[2] = new LoLSkill("����", 7, 7f);
        skills[3] = new LoLSkill("�����þ��� ����", 30, 30f);
    }

    public override void Q()
    {
        Debug.Log("����Ÿ");
    }
    public override void W()
    {
        Debug.Log("���");
    }
    public override void E()
    {
        Debug.Log("����");
    }
    public override void R()
    {
        Debug.Log("�����þ��� ����");
    }
}
