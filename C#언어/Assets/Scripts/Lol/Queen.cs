using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Queen : ChampionInfo
{
    public Queen(string name, int lv, float maxHp) : base(name, lv, maxHp)
    {
        skills[0] = new LoLSkill("실명 공격", 4, 6);
        skills[1] = new LoLSkill("예리한 감각", 6, 5);
        skills[2] = new LoLSkill("공중 제비", 3, 7);
        skills[3] = new LoLSkill("후방 지원", 30, 15);
    }

    public override void Q()
    {
        Debug.Log("실명 공격");
    }
    public override void W()
    {
        Debug.Log("예리한 감각");
    }
    public override void E()
    {
        Debug.Log("공중 제비");
    }
    public override void R()
    {
        Debug.Log("후방 지원");
    }
}