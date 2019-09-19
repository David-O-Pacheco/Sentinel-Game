using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class moveBullet : MonoBehaviour {

    public Vector3 playerPos;
    public Image getShield;
    health getHealthScript;
    activeShield shieldScript;

	void Start () {

        getHealthScript = new health();
        getHealthScript = GameObject.FindGameObjectWithTag("Scripts").GetComponent<health>();
        shieldScript = new activeShield();
        shieldScript = GameObject.FindGameObjectWithTag("Scripts").GetComponent<activeShield>();

    }
	
	// Update is called once per frame
	void Update () {

        transform.position = Vector3.MoveTowards(new Vector3(transform.position.x, transform.position.y, transform.position.z), playerPos, 500 * Time.deltaTime);

    }

    void OnTriggerEnter(Collider Col)
    {
        if(Col.gameObject.tag == "Player")
        {
            if(shieldScript.activateShield)
            {
                shieldScript.activateShield = false;
                Destroy(gameObject);
            }
            if (!shieldScript.activateShield)
            {
                getHealthScript.healthSet += 0.005f;
                Destroy(gameObject);
            }
        }
    }
}
