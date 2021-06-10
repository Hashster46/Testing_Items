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

    public List<Item> itemList = new List<Item>();
    public GameObject inventoryDisplay;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            // Add a random item from this list to inventory
            Inventory.instance.AddItem(itemList[Random.Range(0, itemList.Count)], 1);
        }
    }

    public void OnItemSlotClicked(ItemSlot itemslot)
    {
        inventoryDisplay.GetComponent<InventoryUI_DispPanel>().DispPanelUpdate(itemslot);
    }
}
