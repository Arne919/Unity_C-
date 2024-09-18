using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class YeeSang : Pokemon
{
    public YeeSang(string name, eType type, float hp, float atk, float def, float speed) : base(name, type, hp, atk, def, speed)
    {   //생성자: 객체를 생성할때 실행하는 함수
        skills[0] = new PokemonSkill("씨뿌리기", 3.14f, Pokemon.eType.grass);
        skills[1] = new PokemonSkill("덩쿨채찍", 5f, Pokemon.eType.grass);
        skills[2] = new PokemonSkill("리프토네이도", 2f, Pokemon.eType.grass);
        skills[3] = new PokemonSkill("대충풀", 1.5f, Pokemon.eType.grass);
    }

    //public override void Skill1()
    //{
    //    Debug.Log("씨뿌리기");
    //}
    //public override void Skill2()
    //{
    //    Debug.Log("덩쿨채찍");
    //}
    //public override void Skill3()
    //{
    //    Debug.Log("리프토네이도");
    //}
    //public override void Skill4()
    //{
    //    Debug.Log("대충풀");
    //}
}
