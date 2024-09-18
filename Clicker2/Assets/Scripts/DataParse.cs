using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataParse : MonoBehaviour
{
    //data 파일 읽어 들이기
    public List<Dictionary<string, object>> clickData { get; private set; }

    public List<Dictionary<string, object>> timeData { get; private set; }

    void Awake()
    {
        clickData = CSVReader.Read("ClickData");

        for (int i = 0; i < clickData.Count; i++)
        {
            Debug.Log(clickData[i]["Name"]+" "+ clickData[i]["Cost"]+" "+ clickData[i]["Increase"]);
        }

        timeData = CSVReader.Read("TimeData");

        for (int i = 0; i < timeData.Count; i++)
        {
            Debug.Log(timeData[i]["Name"] + " " + timeData[i]["Cost"] + " " + timeData[i]["Increase"]);
        }
    }
}
