using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Rendering;

public class Champion : MonoBehaviour
{
    private ChampionInfo Champ;

    public ChampionInfo champ 
    {
        get
        {
            return Champ;
        }
        set
        {
            Champ = value;

            lv.text = Champ.lv.ToString();
            name.text = Champ.name;

            hpSlider.maxValue = Champ.maxHp;
            hpSlider.value = Champ.maxHp;

            for (int i = 0; i < 4; i++)
            {
                champ.skills[i].coolTimeUI = skillCoolTimeUis[i];
            }
        }
    }

    public PopupWindow pw;

    [SerializeField] Champion other;

    [SerializeField] TextMeshProUGUI lv;
    [SerializeField] TextMeshProUGUI name;
    [SerializeField] Slider hpSlider;

    [SerializeField] TextMeshProUGUI gameOverText;

    [SerializeField] TextMeshProUGUI[] skillCoolTimeUis = new TextMeshProUGUI[4];


    public void UseSkill (int index)
    {
        if (!champ.skills[index].isOn)
            return;

        pw.TextChange(champ, index);

        champ.skills[index].Use();

        other.Hit(champ.skills[index].damage);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="damage">¾ç¼ö</param>
    public void Hit(float damage)
    {
        Champ.currntHp -= damage;
        hpSlider.value = Champ.currntHp;

        if(Champ.currntHp <= 0)
        {
            gameOverText.gameObject.SetActive(true);
            OnDead();
        }
    }

    protected virtual void OnDead()
    {
        gameOverText.text = "Lose";
    }

    protected void Update()
    {
        for (int i = 0; i < 4; i++)
        {
            if (!Champ.skills[i].isOn)
            {
                Champ.skills[i].remainTime -= Time.deltaTime;
            }
        }


    }

}
