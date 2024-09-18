using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teemo : ChampionInfo
{
    public Teemo(string name, int lv, float maxHp) : base(name, lv, maxHp)
    {
        skills[0] = new LoLSkill("실명 다트", 3, 2f);
        skills[1] = new LoLSkill("신속한 이동", 2, 10f);
        skills[2] = new LoLSkill("맹독 다트", 2, 3f);
        skills[3] = new LoLSkill("유독성 함정", 13, 8f);

    }

    public override void Q()
    {
        Debug.Log("실명 다트");
    }
    public override void W()
    {
        Debug.Log("신속한 이동");
    }
    public override void E()
    {
        Debug.Log("맹독 다트");
    }
    public override void R()
    {
        Debug.Log("유독성 함정");
    }
}
