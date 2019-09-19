using UnityEngine;
using System.Collections;

public class bullet : MonoBehaviour {

    public Transform crosshair;
    float aliveTimer;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        transform.Translate(Vector3.forward * 1000 * Time.deltaTime);

        if(aliveTimer < 2)
        {
            aliveTimer += Time.deltaTime;
        }

        if(aliveTimer >= 2)
        {
            Destroy(gameObject, 2.0f);
        }

    }

    void OnTriggerEnter(Collider Col)
    {
        if(Col.gameObject.tag == "Bullet")
        {
            Destroy(gameObject);
        }
    }
}
