using UnityEngine;
using System.Collections;

public class spawnShips : MonoBehaviour {

    public GameObject spaceship, spaceship2;
    Vector3 prePosition1, prePostition2, prePosition3, prePosition4;
    public float timer;
    bool getPrePosition, once1, once2, once3, once4;
    public int prePos, randShip;
    public int difficulty;



    void Start () {
	
	}
	
	void Update () {

        SpawnShips();

    }

    void SpawnShips()
    {
        if (timer < 5 - difficulty)
        {
            timer += Time.deltaTime;
        }

        if (timer >= 5 - difficulty)
        {
            getPrePosition = true;
            timer = 0;
        }

        if (getPrePosition == true)
        {
            randShip = Random.Range(1, 3);
            prePos = Random.Range(1, 5);
            getPrePosition = false;
        }

        if (prePos == 1 && !once1)
        {
            if (randShip == 1)
            {
                Instantiate(spaceship, new Vector3(0, 0, 920), Quaternion.identity);
            }
            if (randShip == 2)
            {
                Instantiate(spaceship2, new Vector3(0, 0, 920), Quaternion.Euler(-90, 0, 180)); //transform.rotation
            }
            prePos = 0;
            randShip = 0;
            once1 = true;
            once2 = false;
            once3 = false;
            once4 = false;
        }

        if (prePos == 2 && !once2)
        {
            if (randShip == 1)
            {
                Instantiate(spaceship, new Vector3(-237, 112, 920), Quaternion.identity);
            }
            if (randShip == 2)
            {
                Instantiate(spaceship2, new Vector3(-237, 112, 920), Quaternion.Euler(-90, 0, 180)); //transform.rotation
            }
            prePos = 0;
            randShip = 0;
            once2 = true;
            once1 = false;
            once3 = false;
            once4 = false;
        }

        if (prePos == 3 && !once3)
        {
            if (randShip == 1)
            {
                Instantiate(spaceship, new Vector3(215, 40, 920), Quaternion.identity);
            }
            if (randShip == 2)
            {
                Instantiate(spaceship2, new Vector3(215, 40, 920), Quaternion.Euler(-90, 0, 180)); //transform.rotation
            }
            prePos = 0;
            randShip = 0;
            once3 = true;
            once1 = false;
            once2 = false;
            once4 = false;
        }

        if (prePos == 4 && !once4)
        {
            if (randShip == 1)
            {
                Instantiate(spaceship, new Vector3(-215, -47, 920), Quaternion.identity);
            }
            if (randShip == 2)
            {
                Instantiate(spaceship2, new Vector3(-215, -47, 920), Quaternion.Euler(-90, 0, 180)); //transform.rotation
            }
            prePos = 0;
            randShip = 0;
            once4 = true;
            once1 = false;
            once2 = false;
            once3 = false;
        }
    }

}
