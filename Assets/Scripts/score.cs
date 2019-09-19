using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class score : MonoBehaviour {

    public Text scoreNum;
    public int scoreAmount;
    public GameObject boss;
    spawnShips spawnScript;
    public GameObject shieldObj;
    int shieldAmount;
    bool trigOnce, trigOnce2, trigOnce3, trigOnce4;

	void Start () {

        spawnScript = new spawnShips();
        spawnScript = GameObject.FindGameObjectWithTag("Scripts").GetComponent<spawnShips>();

    }
	
	void Update () {

        scoreNum.text = "" + scoreAmount;

        if(scoreAmount >= 1000 && !trigOnce)
        {
            spawnScript.difficulty += 1;
            Instantiate(boss, new Vector3(0, 57, 1078), Quaternion.identity);
            trigOnce = true;
        }

        if(scoreAmount >= 2000 && !trigOnce2)
        {
            spawnScript.difficulty += 1;
            trigOnce2 = true;
        }

        if(scoreAmount >= 4000 && !trigOnce3)
        {
            spawnScript.difficulty += 1;
            Instantiate(boss, new Vector3(0, 57, 1078), Quaternion.identity);
            trigOnce3 = true;
        }

        if(scoreAmount >= 8000 && !trigOnce4)
        {
            spawnScript.difficulty += 1;
            Instantiate(boss, new Vector3(0, 57, 1078), Quaternion.identity);
            trigOnce4 = true;
        }

        if(scoreAmount >= shieldAmount + 300)
        {
            Instantiate(shieldObj, new Vector3(0, 8.1f, 60), Quaternion.identity);
            shieldAmount += 300;
        }

    }
}
