using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryUI_DispPanel : MonoBehaviour
{
    public GameObject itemLabelText;
    public GameObject itemIcon;
    public GameObject itemDescriptionText;
    public GameObject itemAmountText;

    public void DispPanelUpdate(ItemSlot itemslot)
    {
        SetItemLabelText(itemslot.Item.name);
        SetItemIcon(itemslot.Item.icon);
        SetItemDescriptionText(itemslot.Item.description);
        SetItemAmountText(itemslot.itemAmount);
    }


    private void SetItemLabelText(string label)
    {
        itemLabelText.GetComponent<Text>().text = label;
    }

    private void SetItemIcon(Sprite icon)
    {
        itemIcon.GetComponent<Image>().sprite = icon;
    }

    private void SetItemDescriptionText(string desc)
    {
        itemDescriptionText.GetComponent<Text>().text = desc;
    }

    private void SetItemAmountText(int amount)
    {
        itemAmountText.GetComponent<Text>().text = "x" + amount.ToString();
    }

}
