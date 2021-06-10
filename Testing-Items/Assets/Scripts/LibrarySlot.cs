using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LibrarySlot : MonoBehaviour
{
    public Image icon;
    public Item item;

    public void AddItem(Item newItem)
    {
        item = newItem;
        icon.sprite = newItem.icon;
    }

    public void OnClickItemSlot()
    {
        Inventory.instance.AddItem(item, 1);
    }
}
