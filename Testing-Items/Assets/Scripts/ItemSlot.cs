using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemSlot : MonoBehaviour
{
    public Image icon;
    public int itemAmount;
    private Transform amountText;
    [SerializeField]
    private Item item;
    public Item Item => item;


    private void Start()
    {
        amountText = transform.Find("Text");
    }
    private void Update()
    {
        amountText.GetComponent<Text>().text = itemAmount.ToString();
    }

    public void AddItem(Item newItem, int amount)
    {
        item = newItem;
        icon.sprite = newItem.icon;
        itemAmount = amount;
    }

    public void UseItem()
    {
        if(item != null)
        {
            item.Use();
            GameManager.instance.OnItemSlotClicked(this);
        }
    }

    public void DestroySlot()
    {
        Destroy(gameObject);
    }
}
