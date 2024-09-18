using UnityEngine;

public class EnemyChamp : Champion
{

    public const float minTime = 1.5f;
    public const float maxTime = 3.0f;

    float atkTime;
    float t = 0;

    private void Awake()
    {
        atkTime = Random.Range(minTime, maxTime);
    }

    protected override void OnDead()
    {
        gameOverText.text = "Win";
    }

    // Update is called once per frame
    void Update()
    {

            base.Update();

        t += Time.deltaTime;
        if (t > atkTime)
        {

            t = 0;
            atkTime = Random.Range(minTime, maxTime);

            List<int> skilldexList = new List<int>();

            for(int i = 0; i < 4; i++)
            {
                if (champ.skills[i].isOn)
                {
                    skillIndexList.Add(i);
                }
            }
            if(skillIndexList.Count > 0)
            {
                int randomIndex = Random.Range(0, skillIndexList.Count);

                UseSkill(skillIndexList[randomIndex]);
            }
            else
            {
                Debug.Log("��밡���� ��ų ����");
            }
            

            UseSkill(Random.Range(0, 4));
            
        }
    }

}

// ��� ������ ��ų���� ������ ���� ����ϰԲ�
// ���� ��밡���� ��ų�� ���ٸ� debug.log ��밡���� ��ų �����̶�� ����