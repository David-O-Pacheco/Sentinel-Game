using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class activeShield : MonoBehaviour {

    public bool activateShield;
    public Image shieldImage;

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (activateShield)
        {
            shieldImage.enabled = true;
        }
        if (!activateShield)
        {
            shieldImage.enabled = false;
        }

	}
}
