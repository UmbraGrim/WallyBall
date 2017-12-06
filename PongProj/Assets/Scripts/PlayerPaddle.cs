using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerPaddle : MonoBehaviour {

    [SerializeField]
    private float paddleSpeed;

    // Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        var z = Input.GetAxis("Vertical") * Time.deltaTime * paddleSpeed;
        transform.Translate(0,0,z);
	}
}
