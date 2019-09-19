using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class health : MonoBehaviour {
    public Image healthDisplay;
    public Text lose;
    public float healthSet, timer;
    public bool triggerAnim;

	void Start () {

	}
	

	void Update () {
        healthDisplay.fillAmount = 1f - healthSet;

        if(healthDisplay.fillAmount <= 0f)
        {
            lose.enabled = true;
        }
	}
}
