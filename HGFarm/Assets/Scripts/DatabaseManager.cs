using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DatabaseManager : MonoBehaviour
{
    static public DatabaseManager instance;

    public List<Item> itemList = new List<Item>();

    void Start()
    {
        itemList.Add(new Item(10001, "������ �й���", "�翡 ���� �Ѹ� �� �ִ�", Item.ItemType.Equip));
    }


}
