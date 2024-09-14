using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class Gamemanager : MonoBehaviour
{
    public static Gamemanager instance;

    [SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] TextMeshProUGUI bestScoreText;

    //���� �������κ��� �帥 �ð�
    //������ ���п�
    public float levelTime { get; private set; }

    bool isGameOver = false;

    int bestScore;

    int Score = 0;

    public int score
    {
        get
        {
            return Score;
        }
        set
        {
            Score = value;

            scoreText.text = Score.ToString();
        }
    }

    //������ ����
    [SerializeField] GameObject original;
    float t;
    float spwanTime = 0.5f;

    //�������� ���� ���� ��ġ
    Vector3 randPos = Vector3.zero;

    const string bestScoreName = "BestScore";

    public void SetTimeScale(int scale)
    {
        if (!isGameOver)
        {
            Time.timeScale = scale;
        }

        
    }

    public void DataReset()
    {
        PlayerPrefs.SetInt(bestScoreName, 0);
        bestScore = 0;
        bestScoreText.text = bestScore.ToString();
    }

    void Awake()
    {
        instance = this;

        isGameOver = false;

        //�ְ����� ��������
        bestScore = PlayerPrefs.GetInt(bestScoreName, 0);
        bestScoreText.text = bestScore.ToString();

        score = 0;
    }

    [SerializeField] GameObject gameoverText;

    public void GameOver()
    {
        isGameOver = true;

        if (score > bestScore)
        {
            Debug.Log("�ְ����� �޼�~~");
            PlayerPrefs.SetInt(bestScoreName, score);
        }
        //if (�ְ��������� ���������� Ŭ��)
        //{
        //���������� ����
        //}

        //PlayerPrefs.GetInt();
        //PlayerPrefs.SetInt();


        //�ð� �帣�� �ӵ�
        Time.timeScale = 0;
        gameoverText.SetActive(true);
    }

    //0.2~ 0.4~ ���� ����

    void Start()
    {
        spwanTime = Random.Range(0.2f, 0.4f);
        randPos.y = 4.5f;


        //30�� Ȯ�� 4��
        //30�� Ȯ�� 3��
        //30�� Ȯ�� 2��
        //30�� Ȯ�� 1��
    }

    int GetRandCount()
    {
        float randNum = Random.Range(0.0f, 1.0f);

        if (randNum <= 0.3f)
        {
            return 4;
        }
        else if (randNum <= 0.6f)
        {
            return 3;
        }
        else if (randNum <= 0.9f)
        {
            return 2;
        }
        else
        {
            return 1;
        }
    }

    public void ResetGame()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            ResetGame();
        }

        levelTime += Time.deltaTime;

        t += Time.deltaTime;

        if (t >= spwanTime)
        {
            int randCount = GetRandCount();

            for (int i = 0; i < randCount; i++)
            {
                GameObject temp = GameObject.Instantiate(original);
                randPos.x = Random.Range(-8f, 8f);
                temp.transform.position = randPos;
            }
        

        t = 0;
        spwanTime = Random.Range(0.2f, 0.4f);
        }
        
    }
}
