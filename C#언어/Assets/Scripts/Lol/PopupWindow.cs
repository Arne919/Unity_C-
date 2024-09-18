using UnityEngine;
using TMPro;

public class PopupWindow
{
    public TextMeshProUGUI textUi;

    public float disableTime = 1f;
    float t = 0;

    private void Awake()
    {
        Debug.Log("어웨이크");
        textUi = transform.GetChild(0).GetComponent<TextMeshProUGUI>(); //앞에 this. 생략
    }

    public void TextChange(ChampionInfo champ, int index)
    {
        this.gameObject.SetActive(true);
        textUi.text = champ.name + "이(가) " + champ.skills[index].name + "사용";
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