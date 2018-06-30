using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RunnerCamera : MonoBehaviour {

    private void Update()
    {
        if (transform.position.z > 100f){
            transform.position = new Vector3(transform.position.x, transform.position.y, 100f);
        }
    }
}
