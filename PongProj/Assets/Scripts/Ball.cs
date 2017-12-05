using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour {

    //creates a GameObject in the inspector to drop a game object in, giving it the properties below
    public GameObject ball;

    //SerializeField variables, private so only accessable by this class. Serialize field allows them to be modified in inspector
    [SerializeField]
    private float ballSpeed;// = 10.0f;
    [SerializeField]
    private float speedIncrease;
    [SerializeField]
    private float maxSpeed;


    // Use this for initialization
	void Start () {
        ball.GetComponent<Rigidbody>().AddForce(Vector3.right * ballSpeed);

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
