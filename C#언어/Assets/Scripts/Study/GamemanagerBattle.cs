using TMPro;
using UnityEngine;

public class GamemanagerBattle : MonoBehaviour
{
    //포켓몬 정보
    [System.Serializable]
    public struct PokemonInfoUi
    {
        public TextMeshProUGUI Lv;
        public TextMeshProUGUI Name;
        public TextMeshProUGUI Hp;
    }
    public PokemonInfoUi meUi;
    public PokemonInfoUi enemyUi;

    //포켓몬 선택창글자
    [SerializeField] TextMeshProUGUI choiceText;
    //전투 로그
    [SerializeField] TextMeshProUGUI textLog;
    //승패 결과
    [SerializeField] TextMeshProUGUI result;
    //스킬 버튼에 들어갈 글자들
    [SerializeField] TextMeshProUGUI[] skillTexts;
    
    //포켓몬 선택창
    [SerializeField] GameObject choice;
    //전투 창
    [SerializeField] GameObject battle;
    //포켓몬 스킬 뒷배경
    [SerializeField] GameObject skillBackground;
    

    Pokemon me;
    Pokemon enemy;

    Pokemon atk;
    Pokemon def;
    Pokemon temp;

    //0번 인덱스 -> 속도가 빠른 포켓몬이 사용하는 스킬의 인덱스
    //1번 인덱스 -> 속도가 느린 포켓몬이 사용하는 스킬의 인덱스
    int[] skillindex = new int[2];

    //적 선택할 순간인가?
    bool enemyChoice = false;

    bool skillChoice = true;

    Firy firy = new Firy("파이리", Pokemon.eType.fire, 39, 52, 43, 65);
    Ggobugi ggobugi = new Ggobugi("꼬부기", Pokemon.eType.water, 44, 48, 65, 43);
    YeeSang yeeSang = new YeeSang("이상해씨", Pokemon.eType.grass, 45, 49, 49, 45);

    /// <summary>
    /// 느린포켓몬을 공격했는가?
    /// </summary>
    bool slowPokemonChk = false;

    /// <summary>
    /// 텍스트 로그 클릭시
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
            //공수교대
            temp = atk;
            atk = def;
            def = temp;

            textLog.text += atk.name + "의 " + atk.skills[skillindex[1]].name;
            atk.Attack(def, atk.skills[skillindex[1]]);
            SetHp();
        }
    }

    /// <summary>
    /// 스킬 버튼 클릭시
    /// </summary>
    /// <param name="n"></param>
    public void SkillClick(int n) //내가 선택한 스킬의 인덱스
    {
        atk = me;
        def = enemy;

        if (atk.speed < def.speed)
        {   //스피드 비교
            temp = atk;
            atk = def;
            def = temp;
        }

        skillindex[0] = n;
        skillindex[1] = Random.Range(0, 4);
        
        if (atk == enemy) //적 스킬
        {
            int itemp = skillindex[0];
            skillindex[0] = skillindex[1];
            skillindex[1] = itemp;
        }

        textLog.text = atk.name + "의 " + atk.skills[skillindex[0]].name + "\n";
        atk.Attack(def, atk.skills[skillindex[0]]);
        SetHp();
    }

    /// <summary>
    /// 포켓몬 선택시
    /// </summary>
    /// <param name="n">선택한 포켓몬의 인덱스</param>
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

        if (enemyChoice) //적 포켓몬 선택할순간?ㅇㅇ
        {
            //적 포켓몬 설정
            enemy = temp;
            choice.SetActive(false); //화면전환
            battle.SetActive(true);
            TextSet(); //포켓몬세팅
        }
        else //ㄴㄴ
        {
            //내 포켓몬 설정
            me = temp;
            choiceText.text = "상대방 포켓몬 선택";
            enemyChoice = true;   
        }
    }

    /// <summary>
    /// hp설정 및 승패 체크
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

        result.text = me.DeadCheck() ? "Lose" : "Win"; //삼항연산자(참:거짓)


    }

    /// <summary>
    /// 글자 설정 맨처음 한번
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