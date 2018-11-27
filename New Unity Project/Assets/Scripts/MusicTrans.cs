﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicTrans : MonoBehaviour {

    private static MusicTrans instance;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(instance);
        }
        else
        {
            Destroy(gameObject);
        }
    }
}
