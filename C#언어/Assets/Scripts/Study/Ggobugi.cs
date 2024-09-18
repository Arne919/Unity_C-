using UnityEngine;

public class Ggobugi : Pokemon
{
    public Ggobugi(string name, eType type, float hp, float atk, float def, float speed) : base(name, type, hp, atk, def, speed)
    {   //생성자: 객체를 생성할때 실행하는 함수
        skills[0] = new PokemonSkill("물대포", 3.14f, Pokemon.eType.water);
        skills[1] = new PokemonSkill("하이드로펌프", 5f, Pokemon.eType.water);
        skills[2] = new PokemonSkill("껍질숨기", 2f, Pokemon.eType.normal);
        skills[3] = new PokemonSkill("대충물", 1.5f, Pokemon.eType.water);
    }

    //public override void Skill1()
    //{
    //    Debug.Log("물대포");
    //}
    //public override void Skill2()
    //{
    //    Debug.Log("하이드로펌프");
    //}
    //public override void Skill3()
    //{
    //    Debug.Log("껍질숨기");
    //}
    //public override void Skill4()
    //{
    //    Debug.Log("대충물");
    //}
}
