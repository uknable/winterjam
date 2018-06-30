using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandScript : MonoBehaviour {

    public LayerMask layerMask;
    public GameObject egg;
    public bool hasEgg = false;

    Camera cam;

	void Start () {
        cam = Camera.main;
	}

	void Update () {
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if(Physics.Raycast(cam.transform.position, ray.direction, out hit, layerMask))
        {
            transform.position = new Vector3(hit.point.x, hit.point.y, 1.0f);
        }
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Egg" && !hasEgg)
        {
            hasEgg = true;
            egg.SetActive(hasEgg);
            Destroy(other.gameObject);
        }
    }
}
