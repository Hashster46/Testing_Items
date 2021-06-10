using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    #region singleton
    public static GameManager instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    #endregion

    public GameObject inventoryDisplay;

    public void OnItemSlotClicked(ItemSlot itemslot)
    {
        inventoryDisplay.GetComponent<InventoryUI_DispPanel>().DispPanelUpdate(itemslot);
    }
}
