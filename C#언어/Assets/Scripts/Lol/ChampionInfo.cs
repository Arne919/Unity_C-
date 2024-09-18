using UnityEngine;

public class ChampionInfo
{
    public ChampionInfo(string name, int lv, float maxHp)
    {
        this.name = name;
        this.lv = lv;
        this.maxHp = maxHp;
        this.currntHp = maxHp;
        
    }

    public string name;
    public int lv;
    public float currntHp;
    public float maxHp;

    public LoLSkill[] skills = new LoLSkill[4];

    public virtual void Q()
    {

    }
    public virtual void W()
    {

    }
    public virtual void E()
    {

    }
    public virtual void R()
    {

    }
}
