using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class shooting : MonoBehaviour {

    public AudioSource toggle;
    public Image mouse, keyboard, controller;
    float mouseX, mouseY, mousePos;
    int speed = 40;
    public int togglePeripheral;
    Vector3 mousePosition;




    void Start () {

        Cursor.lockState = CursorLockMode.Locked;
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = false;

        togglePeripheral = 0;

    }
	
	void Update () {

        MoveCrosshair();

	}

    void MoveCrosshair()
    {
        //https://www.youtube.com/watch?v=pK1CbnE2VsI I used this resource to help me with mouse position
        Vector3 mousePos = new Vector3(Input.mousePosition.x, Input.mousePosition.y, 250);
        Vector3 cursorPos = Camera.main.ScreenToWorldPoint(mousePos);

        //mousePosition = new Vector3(mousePos.x, mousePos.y, 0);

        if (Input.GetKeyDown(KeyCode.C) && togglePeripheral == 0)
        {
            togglePeripheral = 1;
            toggle.Play();

        }
        else if(Input.GetKeyDown(KeyCode.C) && togglePeripheral == 1)
        {
            togglePeripheral = 2;
            toggle.Play();
        }
        else if (Input.GetKeyDown(KeyCode.C) && togglePeripheral == 2)
        {
            togglePeripheral = 0;
            toggle.Play();
        }

        if (togglePeripheral == 0)
        {
            keyboard.enabled = true;
            mouse.enabled = false;
            controller.enabled = false;

            if (Input.GetKey(KeyCode.W))
            {
                transform.Translate(0, speed * Time.deltaTime, 0);
            }

            if (Input.GetKey(KeyCode.A))
            {
                transform.Translate(-speed * Time.deltaTime, 0, 0);
            }

            if (Input.GetKey(KeyCode.S))
            {
                transform.Translate(0, -speed * Time.deltaTime, 0);
            }

            if (Input.GetKey(KeyCode.D))
            {
                transform.Translate(speed * Time.deltaTime, 0, 0);
            }
        }

        else if (togglePeripheral == 1)
        {
            transform.position = new Vector3(cursorPos.x, cursorPos.y, cursorPos.z - 100);

            keyboard.enabled = false;
            controller.enabled = false;
            mouse.enabled = true;
        }

        else if(togglePeripheral == 2)
        {
            //https://www.youtube.com/watch?v=J8HaAyLzPh4

            transform.Translate(0, Input.GetAxis("Vertical") * Time.deltaTime * speed, 0);

            transform.Translate(Input.GetAxis("Horizontal") * Time.deltaTime * speed, 0, 0);

            controller.enabled = true;
            keyboard.enabled = false;
            mouse.enabled = false;
        }

    }

}

