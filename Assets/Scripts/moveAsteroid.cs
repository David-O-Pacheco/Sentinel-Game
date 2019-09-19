using UnityEngine;
using System.Collections;

public class moveAsteroid : MonoBehaviour {

    health healthScript;
    Vector3 playerPos;

	void Start () {

        playerPos = new Vector3(-1.1f,- 38.6f,- 8.7f);
        healthScript = new health();
        healthScript = GameObject.FindGameObjectWithTag("Scripts").GetComponent<health>();

	}
	
	void Update () {

        transform.position = Vector3.MoveTowards(new Vector3(transform.position.x, transform.position.y, transform.position.z), playerPos, 20 * Time.deltaTime);
        transform.Rotate(Vector3.up, 60 * Time.deltaTime);
        transform.Rotate(Vector3.right, 60 * Time.deltaTime);

        if(transform.position == playerPos)
        {
            healthScript.healthSet += 0.03f;
            Destroy(gameObject);
        }

    }


    void OnTriggerEnter(Collider Col)
    {
        if (Col.gameObject.tag == "Bullet")
        {
            GameObject.Destroy(gameObject);
        }
    }

}
