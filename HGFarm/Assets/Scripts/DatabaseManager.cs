using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DatabaseManager : MonoBehaviour
{
    static public DatabaseManager instance;

    public List<Item> itemList = new List<Item>();

    void Start()
    {
        itemList.Add(new Item(10001, "마법의 분무기", "밭에 물을 뿌릴 수 있다", Item.ItemType.Equip));
    }


}
