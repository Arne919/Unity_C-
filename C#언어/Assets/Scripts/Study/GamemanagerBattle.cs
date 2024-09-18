using TMPro;
using UnityEngine;

public class GamemanagerBattle : MonoBehaviour
{
    //���ϸ� ����
    [System.Serializable]
    public struct PokemonInfoUi
    {
        public TextMeshProUGUI Lv;
        public TextMeshProUGUI Name;
        public TextMeshProUGUI Hp;
    }
    public PokemonInfoUi meUi;
    public PokemonInfoUi enemyUi;

    //���ϸ� ����â����
    [SerializeField] TextMeshProUGUI choiceText;
    //���� �α�
    [SerializeField] TextMeshProUGUI textLog;
    //���� ���
    [SerializeField] TextMeshProUGUI result;
    //��ų ��ư�� �� ���ڵ�
    [SerializeField] TextMeshProUGUI[] skillTexts;
    
    //���ϸ� ����â
    [SerializeField] GameObject choice;
    //���� â
    [SerializeField] GameObject battle;
    //���ϸ� ��ų �޹��
    [SerializeField] GameObject skillBackground;
    

    Pokemon me;
    Pokemon enemy;

    Pokemon atk;
    Pokemon def;
    Pokemon temp;

    //0�� �ε��� -> �ӵ��� ���� ���ϸ��� ����ϴ� ��ų�� �ε���
    //1�� �ε��� -> �ӵ��� ���� ���ϸ��� ����ϴ� ��ų�� �ε���
    int[] skillindex = new int[2];

    //�� ������ �����ΰ�?
    bool enemyChoice = false;

    bool skillChoice = true;

    Firy firy = new Firy("���̸�", Pokemon.eType.fire, 39, 52, 43, 65);
    Ggobugi ggobugi = new Ggobugi("���α�", Pokemon.eType.water, 44, 48, 65, 43);
    YeeSang yeeSang = new YeeSang("�̻��ؾ�", Pokemon.eType.grass, 45, 49, 49, 45);

    /// <summary>
    /// �������ϸ��� �����ߴ°�?
    /// </summary>
    bool slowPokemonChk = false;

    /// <summary>
    /// �ؽ�Ʈ �α� Ŭ����
    /// </summary>
    public void TextLogClick()
    {
        if(slowPokemonChk)
        {
            skillBackground.SetActive(true);
            textLog.gameObject.SetActive(false);
            slowPokemonChk = false;
        }
        else
        {
            slowPokemonChk = true;
            //��������
            temp = atk;
            atk = def;
            def = temp;

            textLog.text += atk.name + "�� " + atk.skills[skillindex[1]].name;
            atk.Attack(def, atk.skills[skillindex[1]]);
            SetHp();
        }
    }

    /// <summary>
    /// ��ų ��ư Ŭ����
    /// </summary>
    /// <param name="n"></param>
    public void SkillClick(int n) //���� ������ ��ų�� �ε���
    {
        atk = me;
        def = enemy;

        if (atk.speed < def.speed)
        {   //���ǵ� ��
            temp = atk;
            atk = def;
            def = temp;
        }

        skillindex[0] = n;
        skillindex[1] = Random.Range(0, 4);
        
        if (atk == enemy) //�� ��ų
        {
            int itemp = skillindex[0];
            skillindex[0] = skillindex[1];
            skillindex[1] = itemp;
        }

        textLog.text = atk.name + "�� " + atk.skills[skillindex[0]].name + "\n";
        atk.Attack(def, atk.skills[skillindex[0]]);
        SetHp();
    }

    /// <summary>
    /// ���ϸ� ���ý�
    /// </summary>
    /// <param name="n">������ ���ϸ��� �ε���</param>
    public void PokemonChoice(int n)
    {
        Pokemon temp = null;

        switch (n)
        {
            case 0:
                temp = firy;
                break;
            case 1:
                temp = ggobugi;
                break;
            case 2:
                temp = yeeSang;
                break;   
        }

        if (enemyChoice) //�� ���ϸ� �����Ҽ���?����
        {
            //�� ���ϸ� ����
            enemy = temp;
            choice.SetActive(false); //ȭ����ȯ
            battle.SetActive(true);
            TextSet(); //���ϸ���
        }
        else //����
        {
            //�� ���ϸ� ����
            me = temp;
            choiceText.text = "���� ���ϸ� ����";
            enemyChoice = true;   
        }
    }

    /// <summary>
    /// hp���� �� ���� üũ
    /// </summary>
    void SetHp()
    {
        if (def == me)
        {
            meUi.Hp.text = me.hp.ToString();

        }
        else
        {
            enemyUi.Hp.text = enemy.hp.ToString();
        }

        result.gameObject.SetActive(def.DeadCheck());

        result.text = me.DeadCheck() ? "Lose" : "Win"; //���׿�����(��:����)


    }

    /// <summary>
    /// ���� ���� ��ó�� �ѹ�
    /// </summary>
    void TextSet()
    {
        meUi.Lv.text = me.lv.ToString();
        meUi.Name.text = me.name;
        meUi.Hp.text = me.hp.ToString();

        enemyUi.Lv.text = enemy.lv.ToString();
        enemyUi.Name.text = enemy.name;
        enemyUi.Hp.text = enemy.hp.ToString();

        for (int i = 0; i < 4; i++)
        {
            skillTexts[i].text = me.skills[i].name;
        }
    }
}