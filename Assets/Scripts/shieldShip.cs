using UnityEngine;
using System.Collections;

public class shieldShip : MonoBehaviour {

    void Start () {


	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter(Collider Col)
    {
        if (Col.gameObject.tag == "Bullet")
        {

                Destroy(gameObject, 0.3f);
            }
        }
    }
