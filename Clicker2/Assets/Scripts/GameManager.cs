using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
using Newtonsoft.Json;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;


    struct SaveData
    {
        int money;
        int clickPerMoney;
        int timePerMoney;
    }

    const string MONEY_KEY = "Money";
    const string TIME_PER_MONEY_KEY = "Time";
    const string CLICK_PER_MONEY_KEY = "Click";
    const string SAVE_DATA_KEY = "SaveData";

    [SerializeField] DataParse dataParse;

    [SerializeField] TextMeshProUGUI moneyText;
    [SerializeField] TextMeshProUGUI clickPerMoneyText;
    [SerializeField] TextMeshProUGUI timePerMoneyText;

    [SerializeField] Transform clickBtParent;
    [SerializeField] Transform timeBtParent;

    [SerializeField] Image image;

    [SerializeField] AudioSource btClick;


    //Color imageColor = Color.white;
    //복제할 원본
    [SerializeField] Upbt upbt;

    SaveData saveData;

    //클릭시 돈 증가량
    int clickPerMoney = 1;
    int timePerMoney = 0;
    int money = 0;

    public int ClickPerMoney
    {
        get
        {
            return clickPerMoney;
        }
        set
        {
            clickPerMoney = value;
            saveData.clickPerMoney = value;
            clickPerMoneyText.text = clickPerMoney.ToString();
        }
    }

    public int TimePerMoney
    {
        get
        {
            return timePerMoney;
        }
        set
        {
            timePerMoney = value;
            saveData.timePerMoney = value;
            timePerMoneyText.text = timePerMoney.ToString();
        }
    }

    public int Money
    {
        get
        {
            return money;
        }
        set
        {
            money = value;
            moneyText.text = money.ToString();
        }
    }


    public void Awake()
    {
        instance = this;

        
        //데이터 불러오기
        string loadJsonData = PlayerPrefs.GetString(SAVE_DATA_KEY, "");


        if(loadJsonData == "")
        {
            DataReSet();
        }
        else
        {
            SavaData loadSaveData;
            //저장했던 json을 saveData 형으로 변환
            loadSaveData = JsonConvert.DeserializeObject<SaveData>(loadJsonData);
            Money = loadSaveData.money;
            ClickPerMoney = loadSaveData.clickPerMoney;
            timePerMoney = loadSaveData.timePerMoney;
        }
        PlayerPrefs.DeleteAll();

    }

    private void Start()
    {
        StartCoroutine(TimeMoney());
        List<Dictionary<string, object>> data = dataParse.clickData;
        //버튼의 복제
        for (int i = 0; i < data.Count; i++)
        {
            Upbt tempbt = Upbt.Instantiate(upbt, clickBtParent);
            tempbt.SetData((string)data[i]["Name"], (int)data[i]["Cost"], (int)data[i]["Increase"],true);
        }

        data = dataParse.timeData;
        for (int i = 0; i < data.Count; i++)
        {
            Upbt tempbt = Upbt.Instantiate(upbt, timeBtParent);
            tempbt.SetData((string)data[i]["Name"], (int)data[i]["Cost"], (int)data[i]["Increase"], false);
        }

    }

    //클릭버튼 클릭시
    public void OnClickBt()
    {
        Money += clickPerMoney;
        btClick.Play();
        //image.color = Random.ColorHSV();
    }

    IEnumerator TimeMoney()
    {
        while (true)
        {
            Money += TimePerMoney;
            yield return new WaitForSeconds(1f);
        }
    }

    public void DataReSet()
    {
        Money = 0;
        ClickPerMoney = 1;
        TimePerMoney = 0;
    }

    private void OnApplicationQuit()
    {
        //save data json화
        //json 변수는 세이브 데이터를 json화 한 것
        string json = JsonConvert.SerializeObject(saveData);

        PlayerPrefs.SetString(SAVE_DATA_KEY, json);


        //PlayerPrefs.SetInt(MONEY_KEY, Money);
        //PlayerPrefs.SetInt(CLICK_PER_MONEY_KEY, ClickPerMoney);
        //PlayerPrefs.SetInt(TIME_PER_MONEY_KEY, TimePerMoney);
    }

}
