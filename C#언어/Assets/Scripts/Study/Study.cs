using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class Study : MonoBehaviour
{

    private void Start()
    {
        //포켓몬 배틀시 스킬 사용하도록
        //랜덤으로

        PokemonT pokemonT = new PokemonT();

        Firy firy = new Firy("파이리", Pokemon.eType.fire, 39, 52, 43, 65);
        Ggobugi ggobugi = new Ggobugi("꼬부기", Pokemon.eType.water, 44, 48, 65, 43);
        YeeSang yeeSang = new YeeSang("이상해씨", Pokemon.eType.grass, 45, 49, 49, 45);

        Pokemon.Battle(ggobugi, yeeSang);

        //pokemonT.Skill1(firy);


        //Zookeeper zookeeper = new Zookeeper();

        //Animal animal = new Animal();

        //Rabbit rabbit = new Rabbit();

        //Tiger tiger = new Tiger();


        //zookeeper.Feeding(animal); //동물이 먹음
        //zookeeper.Feeding(rabbit); //동물이 먹음
        //zookeeper.Feeding(tiger); //동물이 먹음



        //People chulsu = new People();
        //chulsu.name = "철수";
        //chulsu.Eat();
        //chulsu.Sleep();
        //chulsu.Study();

        //Student minsu = new Student();
        //minsu.name = "민수";
        //minsu.Eat();
        //minsu.Sleep();
        //minsu.Study();
        //minsu.GoToSchool();

        //Teacher gildong = new Teacher();
        //gildong.name = "길동";
        //gildong.Eat();
        //gildong.Sleep();
        //gildong.Study();
        //gildong.GoToWork();

        //People peopleMinsu = (People)minsu;
        //peopleMinsu.Sleep();
        ////peopleMinsu.GoToSchool();//자식에서 부모로 형변환: 업캐스팅(그냥 가능)

        //Student minStudent = (Student)peopleMinsu;
        //minStudent.GoToSchool();//부모에서 자식으로 형변환: 다운캐스팅(업했다가 내려가기 가능)



        //Pokemon Firy = new Pokemon("파이리", Pokemon.eType.fire, 39, 52, 43, 65);
        //Pokemon Ggobugi = new Pokemon("꼬부기", Pokemon.eType.water, 44, 48, 65, 43);
        //Pokemon YeeSang = new Pokemon("이상해씨", Pokemon.eType.grass, 45, 49, 49, 45);

        //Pokemon.Battle(faily, yeeSang);

        //Pokemon p1 = new Pokemon("파이리", Pokemon.eType.fire, 50, 30, 20, 5); //객체 생성
        //Debug.Log(p1.name);
        //Debug.Log(p1.type);
        //Debug.Log(p1.hp);
        //Debug.Log(p1.atk);
        //Debug.Log(p1.def);
        //Debug.Log(p1.speed);
        //Debug.Log(Pokemon.count);

        //Pokemon p2 = new Pokemon("꼬부기", Pokemon.eType.water, 99, 88, 77, 6); //객체 생성

        //Debug.Log(Pokemon.count);

        //p1.name = "김포켓몬";
        //p1.lv = 1;
        //p1.hp = 10;
        //p1.exp = 20;
    }

}
