using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    private float startTime; // 게임 시작 시간
    private float elapsedTime; // 경과 시간
    public Text timeText; // UI에 표시할 텍스트

    void Start()
    {
        // 저장된 이전 시간 불러오기
        if (PlayerPrefs.HasKey("TotalTime"))
        {
            elapsedTime = PlayerPrefs.GetFloat("TotalTime");
        }

        // 시작 시간 설정
        startTime = Time.time;
    }

    void Update()
    {
        // 경과 시간 업데이트 (시간을 30배 빨리 흐르게 함)
        elapsedTime += Time.deltaTime * 30f;

        // UI에 시간 표시
        DisplayTime(elapsedTime);
    }

    void DisplayTime(float time)
    {
        // 시간을 시:분 형식으로 변환하여 UI에 표시
        int hours = Mathf.FloorToInt(time / 3600);
        int minutes = Mathf.FloorToInt((time % 3600) / 60);

        timeText.text = string.Format("{0}시:{1}분", hours, minutes);
    }

    // 게임 종료 시 저장된 시간 업데이트
    void OnApplicationQuit()
    {
        PlayerPrefs.SetFloat("TotalTime", elapsedTime);
        PlayerPrefs.Save();
    }
}
