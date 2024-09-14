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

    //게임 시작으로부터 흐른 시간
    //페이지 구분용
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

    //복제할 원본
    [SerializeField] GameObject original;
    float t;
    float spwanTime = 0.5f;

    //복제본의 랜덤 시작 위치
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

        //최고점수 가져오기
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
            Debug.Log("최고점수 달성~~");
            PlayerPrefs.SetInt(bestScoreName, score);
        }
        //if (최고점수보다 현재점수가 클때)
        //{
        //현재점수를 저장
        //}

        //PlayerPrefs.GetInt();
        //PlayerPrefs.SetInt();


        //시간 흐르는 속도
        Time.timeScale = 0;
        gameoverText.SetActive(true);
    }

    //0.2~ 0.4~ 랜덤 생성

    void Start()
    {
        spwanTime = Random.Range(0.2f, 0.4f);
        randPos.y = 4.5f;


        //30퍼 확률 4개
        //30퍼 확률 3개
        //30퍼 확률 2개
        //30퍼 확률 1개
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
