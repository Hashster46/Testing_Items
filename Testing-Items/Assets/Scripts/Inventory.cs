using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Inventory : MonoBehaviour
{

    #region singleton

    public static Inventory instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    #endregion

    //public delegate void OnItemChange();
    //public OnItemChange onItemChange = delegate { };
    public Action onItemChange = delegate { };

    public List<Item> inventoryItemList = new List<Item>();
    public List<int> inventoryItemAmountList = new List<int>();

    public void AddItem(Item item, int amount)
    {
        if (!inventoryItemList.Contains(item))
        {
            inventoryItemList.Add(item);
            inventoryItemAmountList.Add(amount);
        }
        else
        {
            int originalAmount = inventoryItemAmountList[inventoryItemList.IndexOf(item)];
            int newAmount = originalAmount + amount;
            inventoryItemAmountList[inventoryItemList.IndexOf(item)] = newAmount;
        }

        onItemChange.Invoke();
    }
}
