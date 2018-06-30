using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandEggScript : MonoBehaviour {

    public GameObject hand;

    HandScript handScript;

    private void Start()
    {
        handScript = hand.GetComponent<HandScript>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Cup")
        {
            handScript.hasEgg = false;
            gameObject.SetActive(false);
        }
    }
}
