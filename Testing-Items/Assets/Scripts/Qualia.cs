using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
[CreateAssetMenu(fileName = "newQuality", menuName = "Item/baseQuality")]
public class Qualia : ScriptableObject
{
    new public string name = "Default Quality"; // Because scriptable object already has a default value "name", we need to declare a new string "name".
    public Sprite icon = null;
    [TextArea(15, 20)]
    public string description = "";
}


