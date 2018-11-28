﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NextLev : MonoBehaviour
{
    [Tooltip("the name of the next scene")]
    public string SceneName;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Player")
        {
            SceneManager.LoadScene(SceneName); 
        }
    }

}