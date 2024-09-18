using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Garen : ChampionInfo
{
    public Garen(string name, int lv, float maxHp) : base(name, lv, maxHp)
    {
        skills[0] = new LoLSkill("결정타", 6, 3f);
        skills[1] = new LoLSkill("용기", 2, 5f);
        skills[2] = new LoLSkill("심판", 7, 7f);
        skills[3] = new LoLSkill("데마시아의 정의", 30, 30f);
    }

    public override void Q()
    {
        Debug.Log("결정타");
    }
    public override void W()
    {
        Debug.Log("용기");
    }
    public override void E()
    {
        Debug.Log("심판");
    }
    public override void R()
    {
        Debug.Log("데마시아의 정의");
    }
}
