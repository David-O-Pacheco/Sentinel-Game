using UnityEngine;
using System.Collections;

public class bossMove : MonoBehaviour {

    Vector3 prePos;
    public GameObject healthCapsule;
    public int health;
    health getHealthScript;
	
	void Start () {

        prePos = new Vector3(0, 100, 0);
        getHealthScript = new health();
        getHealthScript = GameObject.FindGameObjectWithTag("Scripts").GetComponent<health>();

	}
	
	
	void Update () {

        transform.position = Vector3.MoveTowards(new Vector3(transform.position.x, transform.position.y, transform.position.z), prePos, 5 * Time.deltaTime);

        if(health >= 200)
        {
            if (!GameObject.FindGameObjectWithTag("Capsule"))
            {
                Instantiate(healthCapsule, new Vector3(0, 8.1f, 60), Quaternion.identity);
                Destroy(gameObject, 0.1f);
            }
        }

        if(transform.position == prePos)
        {
            getHealthScript.healthSet = 0.0f;
            Destroy(gameObject);
        }

        if (Input.GetKey(KeyCode.U))
        {
            health = 199;
        }

	}

    void OnTriggerEnter(Collider Col)
    {
        if(Col.gameObject.tag == "Bullet")
        {
            health += 1;
            Destroy(Col.gameObject);
        }
    }
}
