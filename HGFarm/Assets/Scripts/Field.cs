using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class FieldData
{
    //Farm
    public bool isField = false;

    //System
    public float createTime = 0f;
    public bool isWater = false;
    public bool isPlow = false;
    public enum seed
    {
        wheat,//��
        potato,//����
        corn//������
    }
    public float seedGrowth;

}

public class Field
{
    public FieldData[,] FieldData = new FieldData[16 ,16];
    
    private void Updata()
    {

    }

}
