using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasketManager : MonoBehaviour {

    public int score = 0;
    public GameObject[] goodStuff;
    public GameObject[] badStuff;
    public GameObject[] spawns;
	
	void Start () {
        SpawnStuff();
	}

    void SpawnStuff()
    {
        switch(Random.Range(0, 2))
        {
            case 0:
                {
                    Instantiate(goodStuff[Random.Range(0, goodStuff.Length)], spawns[0].transform.position, Quaternion.identity);
                    Instantiate(badStuff[Random.Range(0, badStuff.Length)], spawns[1].transform.position, Quaternion.identity);
                    break;
                }
            case 1:
                {
                    Instantiate(goodStuff[Random.Range(0, goodStuff.Length)], spawns[1].transform.position, Quaternion.identity);
                    Instantiate(badStuff[Random.Range(0, badStuff.Length)], spawns[0].transform.position, Quaternion.identity);
                    break;
                }
            default:
                break;
        }

        Invoke("SpawnStuff", 1.0f);
    }
}
