using UnityEngine;
using System.Collections;

public class healthCapsule : MonoBehaviour {

    health getHealth;
    Vector3 prePos;

	void Start () {

        getHealth = new health();
        getHealth = GameObject.FindGameObjectWithTag("Scripts").GetComponent<health>();
        prePos = new Vector3(0, -2.11f, -13.7f);
	
	}
	
	void Update () {

        transform.position = Vector3.MoveTowards(new Vector3(transform.position.x, transform.position.y, transform.position.z), prePos, 30 * Time.deltaTime);

        if(transform.position == prePos)
        {
            getHealth.healthSet = 0;
            Destroy(gameObject, 0.3f);
        }

	}
}
