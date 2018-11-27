using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class empty : MonoBehaviour{
public GameObject Text;
    
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "emptee")
        {
            Text.SetActive(true);
        }
    }

}

