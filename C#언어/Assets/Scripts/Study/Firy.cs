using UnityEngine;

public class Firy : Pokemon
{
    public Firy(string name, eType type, float hp, float atk, float def, float speed) : base(name, type, hp, atk, def, speed)
    {   //������: ��ü�� �����Ҷ� �����ϴ� �Լ�
        skills[0] = new PokemonSkill("�Ҵ빮��", 3.14f, Pokemon.eType.fire);
        skills[1] = new PokemonSkill("ȭ�����", 5f, Pokemon.eType.fire);
        skills[2] = new PokemonSkill("��ǳ", 2f, Pokemon.eType.fire);
        skills[3] = new PokemonSkill("�����", 1.5f, Pokemon.eType.fire);
    }

    //public override void Skill1()
    //{
    //    Debug.Log("�Ҵ빮��");
    //}
    //public override void Skill2()
    //{
    //    Debug.Log("ȭ�����");
    //}
    //public override void Skill3()
    //{
    //    Debug.Log("��ǳ");
    //}
    //public override void Skill4()
    //{
    //    Debug.Log("�����");
    //}
}
