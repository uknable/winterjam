using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShoppingHand : MonoBehaviour {

    public LayerMask layerMask;
    public GameObject basketManager;

    BasketManager basketManagerScript;

    private void Start()
    {
        basketManagerScript = basketManager.GetComponent<BasketManager>();
    }

    void Update()
    {
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (Physics.Raycast(Camera.main.transform.position, ray.direction, out hit, layerMask))
        {
            transform.position = new Vector3(hit.point.x, hit.point.y, 0f);
        }
    }

    private void OnTriggerStay(Collider other)
    {
        if(other.tag == "GoodStuff" && Input.GetMouseButtonUp(0))
        {
            basketManagerScript.score++;
        }

        if(other.tag == "BadStuff" && Input.GetMouseButtonUp(0))
        {
            basketManagerScript.score--;
        }
    }
}
