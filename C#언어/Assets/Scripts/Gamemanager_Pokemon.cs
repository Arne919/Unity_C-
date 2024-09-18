//MonoBehaviour ����ϱ� ���ؼ�
using UnityEngine;
//TextMeshProUGUI ����ϱ� ���ؼ�
using TMPro;

public class Gamemanager_Pokemon : MonoBehaviour
{

    //�ؽ�Ʈ ���� ����
    //�ۻ���(UI�� text)�� ���� �����ϱ� ���ؼ�
    //public -> �������: inspector���� ������ ���� �ʱ�ȭ�ϱ� ���ؼ�
    public TextMeshProUGUI myType; //���� �� �´���
    public TextMeshProUGUI enemyType;
    public TextMeshProUGUI damage;


    int mypokemon; //�����ϸ�
    int enemypokemon; //������ϸ�
    float effect; //ȿ��

    enum eType //������
    {
        normal,
        fire,
        water,
        grass,
        electric
    };


    //0 = �븻
    //1 = �Ҳ�
    //2 = ��
    //3 = Ǯ
    //4 = ����
    string[] type =
    {
        "normal","fire","water","grass","electric"
    };


    //string[] effectdamage =
    //{   //.5f      1       2
    //    "Not good","Good","Perfect"
    //};


    float[,] typedamage = //ȿ��������(��ǥ����)
    {
        {1,1,1,1,1},
        {1,0.5f,0.5f,2,1},
        {1,2,0.5f,0.5f,1},
        {1,0.5f,2,0.5f,1},
        {1,1,2,0.5f,0.5f}
    };

    //��ư Ŭ���� ������ �Լ�
    //Ŭ���� ��ư���� ���� ������ ����
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

    ////������̸�
    //public void Type(int type)
    //{
    //    me = type;
    //    EnemyChoice();
    //}


    private void EnemyChoice() //�İ�(����) �Լ�
    {
        enemypokemon = Random.Range(0, 5);

        //��&��� ���ϸ� ǥ��
        myType.text = type[mypokemon];
        enemyType.text = type[enemypokemon];

        DamageEffect();
    }

    private void DamageEffect() //������ ȿ��
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