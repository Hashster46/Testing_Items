using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
[CreateAssetMenu(fileName = "Item", menuName = "Item/baseItem")]
public class Item : ScriptableObject
{
    new public string name = "Default Item"; // Because scriptable object already has a default value "name", we need to declare a new string "name".
    public Sprite icon = null;
    [TextArea(15,20)]
    public string description = "";

    public virtual void Use()
    {
        Debug.Log("Using " + name);
    }
}
