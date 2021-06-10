using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InventoryUI : MonoBehaviour
{
    private bool inventoryOpen = false;
    public bool InventoryOpen => inventoryOpen;

    public GameObject InventoryParent;
    public GameObject itemLibraryTab;
    public GameObject inventoryTab;
    public GameObject craftingTab;

    public GameObject itemSlotPrefab;
    public Transform inventoryItemTransform;
    private List<ItemSlot> itemSlotList = new List<ItemSlot>();
    
    
    private void Start()
    {
        Inventory.instance.onItemChange += UpdateInventoryUI;
        UpdateInventoryUI(); // To initialize at the beginning
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            if (inventoryOpen)
            {
                //Close inventory
                CloseInventory();
            }
            else
            {
                //Open inventory
                OpenInventory();
                
            }
        }
    }

    private void UpdateInventoryUI()
    {
        int currentItemCount = Inventory.instance.inventoryItemList.Count;

        if (currentItemCount > itemSlotList.Count)
        {
            //Add more item slots
            AddItemSlots(currentItemCount);
        }

        for(int i = 0; i < itemSlotList.Count; i++)
        {
            if(i <= currentItemCount)
            {
                // Update the current item in the slot based on the item at the same index in the inventory
                itemSlotList[i].AddItem(Inventory.instance.inventoryItemList[i], Inventory.instance.inventoryItemAmountList[i]);
            }
            else
            {
                itemSlotList[i].DestroySlot();
                itemSlotList.RemoveAt(i);
            }
        }
    }

    private void AddItemSlots(int currentItemCount)
    {
        int amount = currentItemCount - itemSlotList.Count;

        for(int i = 0; i < amount; i++)
        {
            GameObject GO = Instantiate(itemSlotPrefab, inventoryItemTransform);
            ItemSlot newSlot = GO.GetComponent<ItemSlot>();
            itemSlotList.Add(newSlot);
        }
    }
    private void OpenInventory()
    {
        inventoryOpen = true;
        InventoryParent.SetActive(true);
    }

    private void CloseInventory()
    {
        inventoryOpen = false;
        InventoryParent.SetActive(false);
    }

    public void OnItemLibraryTabClicked()
    {
        itemLibraryTab.SetActive(true);
        inventoryTab.SetActive(false);
        craftingTab.SetActive(false);
    }

    public void OnInventoryTabClicked()
    {
        itemLibraryTab.SetActive(false);
        inventoryTab.SetActive(true);
        craftingTab.SetActive(false);
    }

    public void OnCraftingTabClicked()
    {
        itemLibraryTab.SetActive(false);
        inventoryTab.SetActive(false);
        craftingTab.SetActive(true);
    }
}
