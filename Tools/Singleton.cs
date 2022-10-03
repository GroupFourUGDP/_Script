using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Singleton<T> : MonoBehaviour where T : Singleton<T>
{
    
    protected static T instancce;
    public static T Instance { get => instancce; }
    public virtual void Awake()
    {
        if (instancce != null)
            Debug.LogError($"{nameof(T)}单例重复,请检查");
        //显示转换时，需要限制该类的继承 where T:SingletonNetwork<T>
        instancce = this as T;
    }
        
}
