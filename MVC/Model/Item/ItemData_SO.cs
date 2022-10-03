using UnityEngine;

[CreateAssetMenu(fileName = "ItemData_SO", menuName = "Data/ItemData_SO")]
public class ItemData_SO : ScriptableObject
{
    
}

public struct Item
{
    //道具名称
    public string name;
    //道具描述
    public string description;
    //道具贴图
    public Sprite itemSticker;
}