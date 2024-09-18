using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Upbt : MonoBehaviour
{
    [SerializeField] TextMeshProUGUI nameText;
    [SerializeField] TextMeshProUGUI costText;
    [SerializeField] TextMeshProUGUI increaseText;

    //업글이름
    string upgradeName;
    //소모비용
    int cost;
    //증가량
    int increase;

    bool isClick = true;

    public void SetData(string _upgradeName, int _cost, int _increase, bool _isClick)
    {
        upgradeName = _upgradeName;
        cost = _cost;
        increase = _increase;
        isClick = _isClick;

        nameText.text = upgradeName;
        costText.text = cost.ToString();
        increaseText.text = increase.ToString();
    }

    public void OnClick()
    {
        if (GameManager.instance.Money < cost)
            return;
        GameManager.instance.Money -= cost;
        if (isClick)
            GameManager.instance.ClickPerMoney += increase;
        else
            GameManager.instance.TimePerMoney += increase;
    }
}
