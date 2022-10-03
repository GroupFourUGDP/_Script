using UnityEngine;

public class BaseCharacter<T> where T : Object
{
    //自己的数据，不影响外部数据
    protected T _data
    {
        get => GameObject.Instantiate(Data);
    }
    [SerializeField]
    public T Data;
}