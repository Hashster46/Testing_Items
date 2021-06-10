using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemRepository : MonoBehaviour
{
    #region Singleton
    public static ItemRepository instance;
    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
    }
    #endregion


    [SerializeField]
    public List<Item> gameItems = new List<Item>();

}
