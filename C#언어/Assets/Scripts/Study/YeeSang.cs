using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;

public class YeeSang : Pokemon
{
    public YeeSang(string name, eType type, float hp, float atk, float def, float speed) : base(name, type, hp, atk, def, speed)
    {   //������: ��ü�� �����Ҷ� �����ϴ� �Լ�
        skills[0] = new PokemonSkill("���Ѹ���", 3.14f, Pokemon.eType.grass);
        skills[1] = new PokemonSkill("����ä��", 5f, Pokemon.eType.grass);
        skills[2] = new PokemonSkill("��������̵�", 2f, Pokemon.eType.grass);
        skills[3] = new PokemonSkill("����Ǯ", 1.5f, Pokemon.eType.grass);
    }

    //public override void Skill1()
    //{
    //    Debug.Log("���Ѹ���");
    //}
    //public override void Skill2()
    //{
    //    Debug.Log("����ä��");
    //}
    //public override void Skill3()
    //{
    //    Debug.Log("��������̵�");
    //}
    //public override void Skill4()
    //{
    //    Debug.Log("����Ǯ");
    //}
}
