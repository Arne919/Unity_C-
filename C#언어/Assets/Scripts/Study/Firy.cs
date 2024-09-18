using UnityEngine;

public class Firy : Pokemon
{
    public Firy(string name, eType type, float hp, float atk, float def, float speed) : base(name, type, hp, atk, def, speed)
    {   //생성자: 객체를 생성할때 실행하는 함수
        skills[0] = new PokemonSkill("불대문자", 3.14f, Pokemon.eType.fire);
        skills[1] = new PokemonSkill("화염방사", 5f, Pokemon.eType.fire);
        skills[2] = new PokemonSkill("열풍", 2f, Pokemon.eType.fire);
        skills[3] = new PokemonSkill("대충불", 1.5f, Pokemon.eType.fire);
    }

    //public override void Skill1()
    //{
    //    Debug.Log("불대문자");
    //}
    //public override void Skill2()
    //{
    //    Debug.Log("화염방사");
    //}
    //public override void Skill3()
    //{
    //    Debug.Log("열풍");
    //}
    //public override void Skill4()
    //{
    //    Debug.Log("대충불");
    //}
}
