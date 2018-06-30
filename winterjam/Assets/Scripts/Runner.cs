using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Runner : MonoBehaviour {

    public float speed = 3.0f;

    float inc = 1.0f;
    bool leftFootDown;
    CharacterController controller;
    Vector3 moveDir = Vector3.zero;
    Vector3 acell = Vector3.forward;

    void Start () {
        leftFootDown = false;
        controller = GetComponent<CharacterController>();
	}
	
	void FixedUpdate () {
		if(Input.GetKeyUp("left") && !leftFootDown)
        {
            print("left");
            moveDir += acell * inc;
            inc = inc + 0.1f;
            leftFootDown = !leftFootDown;
        }

        if(Input.GetKeyUp("right") && leftFootDown)
        {
            print("right");
            moveDir += acell * inc;
            inc = inc + 0.1f;
            leftFootDown = !leftFootDown;
        }
        
        controller.Move(moveDir * Time.deltaTime);
	}
}
