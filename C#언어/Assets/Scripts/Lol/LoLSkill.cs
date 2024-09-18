using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class LoLSkill
{
    public LoLSkill(string _name, float _damage, float _coolTime)
    {
        name = _name;
        damage = _damage;
        coolTime = _coolTime;
    }
    public string name;
    public float damage;
    public float coolTime;
    public TextMeshProUGUI coolTimeUI;


    private float RemainTime = 0;

    public float remainTime
    {
        get
        {
            return RemainTime;
        }
        set
        {
            if (value < 0)
                remainTime = 0;
            else
                remainTime = value;

            if (coolTimeUI != null)
                coolTimeUI.text = RemainTime.ToString("F2");

            if (RemainTime == 0)

                isOn = true;
        }
    }

    public void Use()
    {
        remainTime = coolTime;
        isOn = false;
    }

    public bool isOn = true;



}
