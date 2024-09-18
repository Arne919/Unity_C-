using UnityEngine;
using TMPro;

public class PopupWindow
{
    public TextMeshProUGUI textUi;

    public float disableTime = 1f;
    float t = 0;

    private void Awake()
    {
        Debug.Log("�����ũ");
        textUi = transform.GetChild(0).GetComponent<TextMeshProUGUI>(); //�տ� this. ����
    }

    public void TextChange(ChampionInfo champ, int index)
    {
        this.gameObject.SetActive(true);
        textUi.text = champ.name + "��(��) " + champ.skills[index].name + "���";
        t = 0;

    }


    // Update is called once per frame
    void Update()
    {
        t += Time.deltaTime;
        if (t > disableTime)
        {
            gameObject.SetActive(false);
        }
    }
}