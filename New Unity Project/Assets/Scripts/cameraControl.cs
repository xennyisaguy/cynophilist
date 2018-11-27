using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cameraControl : MonoBehaviour {

    public GameObject ThePlayer;
    private Vector3 traget;
[Tooltip("how fast the camera follows the player")]
    public float cameraMoveSpeed;

 
	
    
	// Update is called once per frame
	void Update () {

        traget = new Vector3(ThePlayer.transform.position.x, transform.position.y, transform.position.z);
        transform.position = Vector3.Lerp(transform.position, traget, cameraMoveSpeed * Time.deltaTime);
    }
}
