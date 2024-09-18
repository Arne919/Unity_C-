using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Pokemon
{   
    //포켓몬 클래스 생성자
    public Pokemon(string name, eType type, float hp, float atk, float def, float speed)
    {   //생성자: 객체를 생성할때 실행하는 함수

        //Debug.Log("부모생성자");
        this.name = name;
        this.type = type;
        this.hp = hp;
        this.atk = atk;
        this.def = def;
        this.speed = speed;
    }

    //포켓몬 타입 열거형
    public enum eType
    {
        normal,
        fire,
        water,
        grass,
    }

    public string name { get; private set; } //get가져오고 set설정
    public eType type { get; private set; }
    
    public int lv { get; private set; }
    private int Exp = 0;
    public int exp //현재경험치
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
    public int maxExp { get; private set; } //레벨업에 필요한 경험치

    public float hp { get; private set; }
    public float atk { get; private set; }
    public float def { get; private set; }
    public float speed { get; private set; }
    public static int count { get; private set; } //static 변수 -> 클래스로 접근/ 멤버 변수 -> 객체로 접근

    //포켓몬이 사용할 스킬들
    public PokemonSkill[] skills = new PokemonSkill[4];


    //가상화
    //상속받은 클래스에서 오버라이트 하기 위해서
    public virtual void Skill1()
    {
        Debug.Log("스킬1");
    }
    public virtual void Skill2()
    {
        Debug.Log("스킬2");
    }
    public virtual void Skill3()
    {
        Debug.Log("스킬3");
    }
    public virtual void Skill4()
    {
        Debug.Log("스킬4");
    }

    //속성에 따른 데미지 배율
    float[,] typedamage = //효과데미지(상성표참고)
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

        //데미지 = 상대의 방어력 - (나의 공격력 * 상성에 따른 공격 비율)*
        float damage = enemy.def - atk * typedamage[(int)skill.type, (int)enemy.type]* skill.damage * stab;
        if (damage > 0)
            damage = -1;
        //상대방의 hit에 데미지 주기
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

   
    //속도가 더 빠른 포켓몬 찾기
    //반복
    //{
    //속도 빠른 포켓몬이 느린 포켓몬을 공격
    //속도 느린 포켓몬이 빠른 포켓몬을 공격
    //} 
    static public void Battle(Pokemon p1, Pokemon p2)
    {
        //p1.HpCheck();
        //p2.HpCheck();
        ////@@의 체력이 없어서 배틀 진행 불가능
        ////체력이 없을때 리턴
        ////체력이 없을때 HpCheck() 뭘 반환? false
        ////조건식이 참일때
        //if (p1.DeadCheck() || p2.DeadCheck())
        //{
        //    return;
        //}

        //Pokemon atk = p1;
        //Pokemon def = p2;

        //if (p1.speed < p2.speed)
        //{   //스피드 비교
        //    atk = p2;
        //    def = p1;
        //}

        //while(true)
        //{

        //    atk.Attack(def); //공격이 방어를 때림

        //    if (def.hp <= 0)
        //    {   //방어의 체력이 0보다 작거나 같으면 종료
        //        Debug.Log(atk.name + "이(가) " + def.name + "과(와) 싸워서 이김");
        //        break;
        //    }

        //    Pokemon temp = atk; //공격을 저장
        //    atk = def; //공격->방어
        //    def = temp; //방어->저장했던 공격
        //}
        //    //공격이 방어를 때리도록
        //    //atk def 그대로 사용    


    }
}