//MonoBehaviour 사용하기 위해서
using UnityEngine;
//TextMeshProUGUI 사용하기 위해서
using TMPro;

public class Gamemanager_Pokemon : MonoBehaviour
{

    //텍스트 변수 선언
    //글상자(UI의 text)에 대해 접근하기 위해서
    //public -> 사용이유: inspector에서 변수에 대해 초기화하기 위해서
    public TextMeshProUGUI myType; //내가 뭘 냈는지
    public TextMeshProUGUI enemyType;
    public TextMeshProUGUI damage;


    int mypokemon; //내포켓몬
    int enemypokemon; //상대포켓몬
    float effect; //효과

    enum eType //열거형
    {
        normal,
        fire,
        water,
        grass,
        electric
    };


    //0 = 노말
    //1 = 불꽃
    //2 = 물
    //3 = 풀
    //4 = 전기
    string[] type =
    {
        "normal","fire","water","grass","electric"
    };


    //string[] effectdamage =
    //{   //.5f      1       2
    //    "Not good","Good","Perfect"
    //};


    float[,] typedamage = //효과데미지(상성표참고)
    {
        {1,1,1,1,1},
        {1,0.5f,0.5f,2,1},
        {1,2,0.5f,0.5f,1},
        {1,0.5f,2,0.5f,1},
        {1,1,2,0.5f,0.5f}
    };

    //버튼 클릭시 실행할 함수
    //클릭한 버튼으로 내가 낸것을 설정
    public void Normal()
    {
        mypokemon = (int)eType.normal;
        EnemyChoice();
    }
    public void Fire()
    {
        mypokemon = (int)eType.fire;
        EnemyChoice();
    }
    public void Water()
    {
        mypokemon = (int)eType.water;
        EnemyChoice();
    }
    public void Grass()
    {
        mypokemon = (int)eType.grass;
        EnemyChoice();
    }
    public void Electric()
    {
        mypokemon = (int)eType.electric;
        EnemyChoice();
    }

    ////↓↓줄이면
    //public void Type(int type)
    //{
    //    me = type;
    //    EnemyChoice();
    //}


    private void EnemyChoice() //컴값(랜덤) 함수
    {
        enemypokemon = Random.Range(0, 5);

        //나&상대 포켓몬 표시
        myType.text = type[mypokemon];
        enemyType.text = type[enemypokemon];

        DamageEffect();
    }

    private void DamageEffect() //데미지 효과
    {

        effect = typedamage[mypokemon, enemypokemon];

        switch(effect)
        {
            case 0.5f:
                damage.text = "Not good";
                break;
            case 1:
                damage.text = "Good";
                break;
            case 2:
                damage.text = "Perfect";
                break;

        }

    }

}