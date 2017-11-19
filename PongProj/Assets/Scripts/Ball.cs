using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    public GameObject ball;
    
    // Use this for initialization
	void Start () {
        ball.GetComponent<Rigidbody>().AddForce(Vector3.right * 10.0f);
        


    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
