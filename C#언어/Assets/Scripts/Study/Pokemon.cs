using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Pokemon
{   
    //���ϸ� Ŭ���� ������
    public Pokemon(string name, eType type, float hp, float atk, float def, float speed)
    {   //������: ��ü�� �����Ҷ� �����ϴ� �Լ�

        //Debug.Log("�θ������");
        this.name = name;
        this.type = type;
        this.hp = hp;
        this.atk = atk;
        this.def = def;
        this.speed = speed;
    }

    //���ϸ� Ÿ�� ������
    public enum eType
    {
        normal,
        fire,
        water,
        grass,
    }

    public string name { get; private set; } //get�������� set����
    public eType type { get; private set; }
    
    public int lv { get; private set; }
    private int Exp = 0;
    public int exp //�������ġ
    { 
        get
        {
            return Exp;
        }
        set
        {
            Exp = value;
            if(Exp >= maxExp)
            {
                Exp = 0;
                lv++;
                maxExp = lv * 10;
            }
        }
    } 
    public int maxExp { get; private set; } //�������� �ʿ��� ����ġ

    public float hp { get; private set; }
    public float atk { get; private set; }
    public float def { get; private set; }
    public float speed { get; private set; }
    public static int count { get; private set; } //static ���� -> Ŭ������ ����/ ��� ���� -> ��ü�� ����

    //���ϸ��� ����� ��ų��
    public PokemonSkill[] skills = new PokemonSkill[4];


    //����ȭ
    //��ӹ��� Ŭ�������� ��������Ʈ �ϱ� ���ؼ�
    public virtual void Skill1()
    {
        Debug.Log("��ų1");
    }
    public virtual void Skill2()
    {
        Debug.Log("��ų2");
    }
    public virtual void Skill3()
    {
        Debug.Log("��ų3");
    }
    public virtual void Skill4()
    {
        Debug.Log("��ų4");
    }

    //�Ӽ��� ���� ������ ����
    float[,] typedamage = //ȿ��������(��ǥ����)
{
        {1,1,1,1},
        {1,0.5f,0.5f,2},
        {1,2,0.5f,0.5f},
        {1,0.5f,2,0.5f},
    };

    public void Attack(Pokemon enemy, PokemonSkill skill)
    {
        float stab = 1f;
        if (type == skill.type)
        {
            stab = 1.5f;
        }

        //������ = ����� ���� - (���� ���ݷ� * �󼺿� ���� ���� ����)*
        float damage = enemy.def - atk * typedamage[(int)skill.type, (int)enemy.type]* skill.damage * stab;
        if (damage > 0)
            damage = -1;
        //������ hit�� ������ �ֱ�
        enemy.Hit(damage);
    }


    public void Hit(float damage)
    {
        hp += damage;
    }

    public bool DeadCheck()
    {
        if (this.hp <= 0)
        {
            return true;
        }
        return false;
    }

   
    //�ӵ��� �� ���� ���ϸ� ã��
    //�ݺ�
    //{
    //�ӵ� ���� ���ϸ��� ���� ���ϸ��� ����
    //�ӵ� ���� ���ϸ��� ���� ���ϸ��� ����
    //} 
    static public void Battle(Pokemon p1, Pokemon p2)
    {
        //p1.HpCheck();
        //p2.HpCheck();
        ////@@�� ü���� ��� ��Ʋ ���� �Ұ���
        ////ü���� ������ ����
        ////ü���� ������ HpCheck() �� ��ȯ? false
        ////���ǽ��� ���϶�
        //if (p1.DeadCheck() || p2.DeadCheck())
        //{
        //    return;
        //}

        //Pokemon atk = p1;
        //Pokemon def = p2;

        //if (p1.speed < p2.speed)
        //{   //���ǵ� ��
        //    atk = p2;
        //    def = p1;
        //}

        //while(true)
        //{

        //    atk.Attack(def); //������ �� ����

        //    if (def.hp <= 0)
        //    {   //����� ü���� 0���� �۰ų� ������ ����
        //        Debug.Log(atk.name + "��(��) " + def.name + "��(��) �ο��� �̱�");
        //        break;
        //    }

        //    Pokemon temp = atk; //������ ����
        //    atk = def; //����->���
        //    def = temp; //���->�����ߴ� ����
        //}
        //    //������ �� ��������
        //    //atk def �״�� ���    


    }
}