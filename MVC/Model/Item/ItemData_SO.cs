using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "ItemData_SO", menuName = "Data/ItemData_SO")]
public class ItemData_SO : ScriptableObject
{
    public List<ItemData> Items = new List<ItemData>();

    public  ItemData GetItem(int id)
    {
        if (Items.Count > 0)
            return Items[id - 1];
        return null;
    }
}
[System.Serializable]
public class ItemData
{
    //道具名称
    [Tooltip("道具名称")]
    public string name;
    //道具描述
    [Tooltip("道具描述")]
    public string description;
    [Tooltip("道具脚本")]
    //道具脚本
    public BaseItemScript itemScript;
    [Tooltip("道具贴图")]
    //道具贴图
    public Sprite itemSticker;
}