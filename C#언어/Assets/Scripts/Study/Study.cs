using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Study : MonoBehaviour
{

    private void Start()
    {
        //���ϸ� ��Ʋ�� ��ų ����ϵ���
        //��������

        PokemonT pokemonT = new PokemonT();

        Firy firy = new Firy("���̸�", Pokemon.eType.fire, 39, 52, 43, 65);
        Ggobugi ggobugi = new Ggobugi("���α�", Pokemon.eType.water, 44, 48, 65, 43);
        YeeSang yeeSang = new YeeSang("�̻��ؾ�", Pokemon.eType.grass, 45, 49, 49, 45);

        Pokemon.Battle(ggobugi, yeeSang);

        //pokemonT.Skill1(firy);


        //Zookeeper zookeeper = new Zookeeper();

        //Animal animal = new Animal();

        //Rabbit rabbit = new Rabbit();

        //Tiger tiger = new Tiger();


        //zookeeper.Feeding(animal); //������ ����
        //zookeeper.Feeding(rabbit); //������ ����
        //zookeeper.Feeding(tiger); //������ ����



        //People chulsu = new People();
        //chulsu.name = "ö��";
        //chulsu.Eat();
        //chulsu.Sleep();
        //chulsu.Study();

        //Student minsu = new Student();
        //minsu.name = "�μ�";
        //minsu.Eat();
        //minsu.Sleep();
        //minsu.Study();
        //minsu.GoToSchool();

        //Teacher gildong = new Teacher();
        //gildong.name = "�浿";
        //gildong.Eat();
        //gildong.Sleep();
        //gildong.Study();
        //gildong.GoToWork();

        //People peopleMinsu = (People)minsu;
        //peopleMinsu.Sleep();
        ////peopleMinsu.GoToSchool();//�ڽĿ��� �θ�� ����ȯ: ��ĳ����(�׳� ����)

        //Student minStudent = (Student)peopleMinsu;
        //minStudent.GoToSchool();//�θ𿡼� �ڽ����� ����ȯ: �ٿ�ĳ����(���ߴٰ� �������� ����)



        //Pokemon Firy = new Pokemon("���̸�", Pokemon.eType.fire, 39, 52, 43, 65);
        //Pokemon Ggobugi = new Pokemon("���α�", Pokemon.eType.water, 44, 48, 65, 43);
        //Pokemon YeeSang = new Pokemon("�̻��ؾ�", Pokemon.eType.grass, 45, 49, 49, 45);

        //Pokemon.Battle(faily, yeeSang);

        //Pokemon p1 = new Pokemon("���̸�", Pokemon.eType.fire, 50, 30, 20, 5); //��ü ����
        //Debug.Log(p1.name);
        //Debug.Log(p1.type);
        //Debug.Log(p1.hp);
        //Debug.Log(p1.atk);
        //Debug.Log(p1.def);
        //Debug.Log(p1.speed);
        //Debug.Log(Pokemon.count);

        //Pokemon p2 = new Pokemon("���α�", Pokemon.eType.water, 99, 88, 77, 6); //��ü ����

        //Debug.Log(Pokemon.count);

        //p1.name = "�����ϸ�";
        //p1.lv = 1;
        //p1.hp = 10;
        //p1.exp = 20;
    }

}
