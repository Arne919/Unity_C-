using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teemo : ChampionInfo
{
    public Teemo(string name, int lv, float maxHp) : base(name, lv, maxHp)
    {
        skills[0] = new LoLSkill("�Ǹ� ��Ʈ", 3, 2f);
        skills[1] = new LoLSkill("�ż��� �̵�", 2, 10f);
        skills[2] = new LoLSkill("�͵� ��Ʈ", 2, 3f);
        skills[3] = new LoLSkill("������ ����", 13, 8f);

    }

    public override void Q()
    {
        Debug.Log("�Ǹ� ��Ʈ");
    }
    public override void W()
    {
        Debug.Log("�ż��� �̵�");
    }
    public override void E()
    {
        Debug.Log("�͵� ��Ʈ");
    }
    public override void R()
    {
        Debug.Log("������ ����");
    }
}
