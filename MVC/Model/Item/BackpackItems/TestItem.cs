using UnityEngine;

[CreateAssetMenu(fileName = "TestItem",menuName = "Item/TestItem")]
public class TestItem : BaseItemScript,IItem
{
    
    public void Execute()
    {
        throw new System.NotImplementedException();
    }

    public void SetDestroy()
    {
        throw new System.NotImplementedException();
    }
}