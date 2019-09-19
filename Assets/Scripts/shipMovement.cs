using UnityEngine;
using System.Collections;

public class shipMovement : MonoBehaviour {

    Vector3 prePos1, prePos2, prePos3, position;
    int randPos, enemySpeed;
    float timer, moveTimer;
    public Vector3 player;
    bool once, sideCh;
    health getHealth;

    public int speed = 70;

	void Start () {

        prePos1 = new Vector3(0, 25, -43);
        prePos2 = new Vector3(-60, 25, -43);
        prePos3 = new Vector3(60, 25, -43);

        getHealth = new health();
        getHealth = GameObject.FindGameObjectWithTag("Scripts").GetComponent<health>();

	}
	
	void Update () {


        if(timer < 1)
        {
            timer += Time.deltaTime;
        }
        
        if(timer >= 1 && once == false)
        {
            randPos = Random.Range(1,3);
            once = true;
        }

            if (randPos == 1)
            {
                transform.position = Vector3.MoveTowards(new Vector3(transform.position.x, transform.position.y, transform.position.z), prePos1, speed * Time.deltaTime);
            RotateShip();
            }

            if (randPos == 2)
            {
                transform.position = Vector3.MoveTowards(new Vector3(transform.position.x, transform.position.y, transform.position.z), prePos2, speed * Time.deltaTime);
            RotateShip();
        }

            if (randPos == 3)
            {
                transform.position = Vector3.MoveTowards(new Vector3(transform.position.x, transform.position.y, transform.position.z), prePos3, speed * Time.deltaTime);
            RotateShip();
        }

            if (moveTimer < 2)
            {
                moveTimer += Time.deltaTime;
            }

            if (moveTimer >= 2 && moveTimer < 4)
            {
                moveTimer += Time.deltaTime;
                position = new Vector3(enemySpeed * Time.deltaTime, 0, 0);
        }

            if (moveTimer >= 2 && !sideCh)
            {
                enemySpeed = Random.Range(-30, 30);
                sideCh = true;
            }

            if (moveTimer >= 4)
            {
                enemySpeed = 0;
                moveTimer = 0;
                sideCh = false;
            }

            transform.Translate(position);

            if (transform.position == prePos1 || transform.position == prePos2 || transform.position == prePos3)
            {
                getHealth.healthSet += 0.05f;
                Destroy(gameObject);
            }


    }

    void RotateShip()
    {
        //Vector3 newRot = player - transform.position;
        //Quaternion rotation = Quaternion.LookRotation(newRot);
        //transform.rotation = rotation;
    }
}
