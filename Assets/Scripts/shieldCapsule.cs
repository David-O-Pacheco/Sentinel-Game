using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class shieldCapsule : MonoBehaviour {

    Vector3 prePos;
    public Image shieldImage;
    activeShield shieldScript;


	void Start () {

        prePos = new Vector3(0, -2.11f, -13.7f);
        shieldScript = new activeShield();
        shieldScript = GameObject.FindGameObjectWithTag("Scripts").GetComponent<activeShield>();

    }
	
	void Update () {

        transform.position = Vector3.MoveTowards(new Vector3(transform.position.x, transform.position.y, transform.position.z), prePos, 30 * Time.deltaTime);

        if(transform.position == prePos)
        {
            Destroy(gameObject, 0.4f);
            shieldScript.activateShield = true;
        }

	}
}
