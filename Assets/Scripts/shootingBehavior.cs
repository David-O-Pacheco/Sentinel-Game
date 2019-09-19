using UnityEngine;
using System.Collections;

public class shootingBehavior : MonoBehaviour {

    public GameObject bullet;
    float randTimer, timer;
    int randNum;


	void Start () {


	}
	

	void Update () {


        if (randTimer < 5)
        {

            randTimer += Time.deltaTime;

        }

        if (randTimer > 5)
        {

            Instantiate(bullet, new Vector3(transform.position.x, transform.position.y, transform.position.z - 1.7f), Quaternion.identity);
            randTimer = 0;

        }


	}
}
