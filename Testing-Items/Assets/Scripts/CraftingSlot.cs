using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class CraftingSlot : MonoBehaviour
{
    public Image icon;
    [SerializeField]
    private Item item;
    public Item Item => item;

    public void SetItem(Item newItem)
    {
        item = newItem;
        icon.sprite = newItem.icon;
    }

    public void RemoveSetItem()
    {
        item = null;
        icon.sprite = null;
    }
}
