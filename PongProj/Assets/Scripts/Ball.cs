using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    //SerializeField variables, private so only accessable by this class. Serialize field allows them to be modified in inspector
    [SerializeField]
    private float ballSpeed = 10f;// = 10.0f;
    [SerializeField]
    private float speedIncrease;
    [SerializeField]
    private float maxSpeed;


    // Use this for initialization
	void Start () {

        float sx = Random.Range(0, 2) == 0 ? -1 : 1;
        float sz = Random.Range(0, 2) == 0 ? -1 : 1;
        GetComponent<Rigidbody>().velocity = new Vector3(ballSpeed * sx, 0f, ballSpeed * sz);
    }
	
	// Update is called once per frame
	void Update () {
        //updateBallSpeed();
    }

    /*//updates in a fixed framerate
    private void FixedUpdate()
    {
        //updateBallSpeed();
    }

    void updateBallSpeed()
    {
        //ballSpeed = 1.0f;
        while (ballSpeed <= 30.0f)
        {
           ball.GetComponent<Rigidbody>().AddForce(Vector3.right * ballSpeed);
           ballSpeed+=speedIncrease;// = (ballSpeed + speedIncrease);
        }         
    }*/
}
