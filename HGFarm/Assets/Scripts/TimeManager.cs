using UnityEngine;
using UnityEngine.UI;

public class TimeManager : MonoBehaviour
{
    private float startTime; // ���� ���� �ð�
    private float elapsedTime; // ��� �ð�
    public Text timeText; // UI�� ǥ���� �ؽ�Ʈ

    void Start()
    {
        // ����� ���� �ð� �ҷ�����
        if (PlayerPrefs.HasKey("TotalTime"))
        {
            elapsedTime = PlayerPrefs.GetFloat("TotalTime");
        }

        // ���� �ð� ����
        startTime = Time.time;
    }

    void Update()
    {
        // ��� �ð� ������Ʈ (�ð��� 30�� ���� �帣�� ��)
        elapsedTime += Time.deltaTime * 30f;

        // UI�� �ð� ǥ��
        DisplayTime(elapsedTime);
    }

    void DisplayTime(float time)
    {
        // �ð��� ��:�� �������� ��ȯ�Ͽ� UI�� ǥ��
        int hours = Mathf.FloorToInt(time / 3600);
        int minutes = Mathf.FloorToInt((time % 3600) / 60);

        timeText.text = string.Format("{0}��:{1}��", hours, minutes);
    }

    // ���� ���� �� ����� �ð� ������Ʈ
    void OnApplicationQuit()
    {
        PlayerPrefs.SetFloat("TotalTime", elapsedTime);
        PlayerPrefs.Save();
    }
}
