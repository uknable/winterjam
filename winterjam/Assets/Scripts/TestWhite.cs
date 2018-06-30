using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestWhite : MonoBehaviour {

    public Transform parent;

    Color color;
    Renderer render;

    private void Start()
    {
        render = GetComponent<Renderer>();
        render.material.color = new Color(color.r, color.g, color.b, 0.5f);
    }

    void Update () {
        transform.position = parent.position;
	}
}
