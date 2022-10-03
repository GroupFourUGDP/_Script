using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicManager : Singleton<MusicManager>
{
    
    // public Action PlayMusic();
    public override void Awake()
    {
        base.Awake();
        DontDestroyOnLoad(this.gameObject);
    }
}
