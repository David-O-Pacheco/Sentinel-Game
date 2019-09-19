using UnityEngine;
using System.Collections;

public class asteroidSpawn : MonoBehaviour {

    float timer;
    int randPos;
    public GameObject asteroid;

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
        if(timer < 10)
        {
            timer += Time.deltaTime;
        }
        
        if(timer >= 10)
        {
            randPos = Random.Range(1, 6);
            timer = 0;
        }

        if(randPos == 1)
        {
            Instantiate(asteroid, new Vector3(39.172f, -40, 984), Quaternion.identity);
            randPos = 0;
        }

        if (randPos == 2)
        {
            Instantiate(asteroid, new Vector3(171, -40, 984), Quaternion.identity);
            randPos = 0;
        }

        if (randPos == 3)
        {
            Instantiate(asteroid, new Vector3(269, 64, 984), Quaternion.identity);
            randPos = 0;
        }

        if (randPos == 4)
        {
            Instantiate(asteroid, new Vector3(-27, 62, 984), Quaternion.identity);
            randPos = 0;
        }

        if (randPos == 5)
        {
            Instantiate(asteroid, new Vector3(-153, 12, 984), Quaternion.identity);
            randPos = 0;
        }

        if (randPos == 6)
        {
            Instantiate(asteroid, new Vector3(-217, 138, 984), Quaternion.identity);
            randPos = 0;

        }
    }
}
