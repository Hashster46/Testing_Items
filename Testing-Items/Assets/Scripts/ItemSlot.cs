using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemSlot : MonoBehaviour
{
    public Image icon;
    private Item item;

    public GameObject itemLabelUI;
    public GameObject itemIconUI;
    public GameObject itemDescriptionUI;

    public void AddItem(Item newItem)
    {
        item = newItem;
        icon.sprite = newItem.icon;
    }

    public void UseItem()
    {
        if(item != null)
        {
            itemLabelUI.text = item.name;
            itemIconUI.Image = item.icon;
            itemDescriptionUI.text = item.description;
            item.Use();
        }
    }

    public void DestroySlot()
    {
        Destroy(gameObject);
    }
}
