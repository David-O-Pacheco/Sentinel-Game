using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class turretMovement : MonoBehaviour {

    public Image energyLeft, energyRight;
    public GameObject bullet;
    public Transform turret;
    public Transform target;
    shooting getShooting;
    bool instOnce, mouseOnce, disableShooting, controllerOnce;


    void Start() {

        getShooting = new shooting();
        getShooting = GameObject.FindGameObjectWithTag("Crosshair").GetComponent<shooting>();

    }

    void Update() {

        Shooting();

        //https://www.youtube.com/watch?v=xPGcBlpRK54 Searched up how to rotate objects towards other objects.

        Vector3 newRot = target.position - transform.position;
        Quaternion rotation = Quaternion.LookRotation(newRot);
        transform.rotation = rotation;

        if (energyLeft.enabled == true && energyRight.enabled == true)
        {
            energyLeft.fillAmount -= 0.03f;
            energyRight.fillAmount -= 0.03f;
            disableShooting = true;
        }

        if (energyLeft.fillAmount == 0f && energyRight.fillAmount == 0f)
        {
            energyLeft.enabled = false;
            energyRight.enabled = false;
            energyLeft.fillAmount = 1f;
            energyRight.fillAmount = 1f;
            disableShooting = false;
        }

    }

    void Shooting()
    {
            if (Input.GetKey(KeyCode.Space) && getShooting.togglePeripheral == 0)
            {
            if (!instOnce)
            {
                Instantiate(bullet, new Vector3(turret.transform.position.x - 0.1f, turret.transform.position.y + 1.6f, turret.transform.position.z + 0.3f), transform.rotation);
                instOnce = true;
                energyLeft.enabled = true;
                energyRight.enabled = true;
            }
        }
        if (!Input.GetKey(KeyCode.Space))
        {
            instOnce = false;
        }

        if (Input.GetMouseButtonDown(0) && getShooting.togglePeripheral == 1)
        {
            if (!mouseOnce)
            {
                Instantiate(bullet, new Vector3(turret.transform.position.x - 0.1f, turret.transform.position.y + 1.6f, turret.transform.position.z + 0.3f), transform.rotation);
                mouseOnce = true;
                energyLeft.enabled = true;
                energyRight.enabled = true;
            }
        }
        if (!Input.GetMouseButtonDown(0))
        {
            mouseOnce = false;
        }

        if(Input.GetKey("joystick button 0") && getShooting.togglePeripheral == 2)
        {
            if (!controllerOnce)
            {
                Instantiate(bullet, new Vector3(turret.transform.position.x - 0.1f, turret.transform.position.y + 1.6f, turret.transform.position.z + 0.3f), transform.rotation);
                controllerOnce = true;
                energyLeft.enabled = true;
                energyRight.enabled = true;

            }
        }
        if(!Input.GetKey("joystick button 0"))
        {
            controllerOnce = false;
        }
    }
        
}
