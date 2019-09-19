using UnityEngine;
using System.Collections;

public class collision : MonoBehaviour {

    public AudioClip explosion;
    score scoreCount;


    void Start () {
        scoreCount = new score();
        scoreCount = GameObject.FindGameObjectWithTag("Scripts").GetComponent<score>();
	}
	
	void Update () {
	
	}


    void OnTriggerEnter(Collider Col)
    {
        if(Col.gameObject.tag == "Bullet")
        {
            scoreCount.scoreAmount += 50;
            AudioSource.PlayClipAtPoint(explosion, new Vector3(0, 0, 0));
            Destroy(gameObject, 0.1f);
        }
    }
}
