using UnityEngine;

public class Ggobugi : Pokemon
{
    public Ggobugi(string name, eType type, float hp, float atk, float def, float speed) : base(name, type, hp, atk, def, speed)
    {   //������: ��ü�� �����Ҷ� �����ϴ� �Լ�
        skills[0] = new PokemonSkill("������", 3.14f, Pokemon.eType.water);
        skills[1] = new PokemonSkill("���̵������", 5f, Pokemon.eType.water);
        skills[2] = new PokemonSkill("��������", 2f, Pokemon.eType.normal);
        skills[3] = new PokemonSkill("���湰", 1.5f, Pokemon.eType.water);
    }

    //public override void Skill1()
    //{
    //    Debug.Log("������");
    //}
    //public override void Skill2()
    //{
    //    Debug.Log("���̵������");
    //}
    //public override void Skill3()
    //{
    //    Debug.Log("��������");
    //}
    //public override void Skill4()
    //{
    //    Debug.Log("���湰");
    //}
}
