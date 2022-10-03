using UnityEditor;

public static class Item
{
    private static ItemData_SO itemDataSo = AssetDatabase.LoadAssetAtPath<ItemData_SO>(@"Assets\Resources\Data\ItemData_SO.asset");
    
}

public enum ItemName
{
    万能钥匙
}