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

    public List<Qualia> qualias = new List<Qualia>();
    public List<int> qualiaAmount = new List<int>();
    public List<Qualia> reactive = new List<Qualia>();
    public List<int> reactiveAmount = new List<int>();

    public virtual void Use()
    {
        Debug.Log("Using " + name);
        Debug.Log(React(qualias[1], 1));
    }

    public virtual int React(Qualia qualia, int amount)
    {
        foreach (Qualia q in reactive)
        {
            if (qualia == q && amount == reactiveAmount.IndexOf(reactive.IndexOf(q)))
            {
                return qualias.IndexOf(q);
            }
            else
            {
                return -1;
            }
        }
        return -2;
    }
}
