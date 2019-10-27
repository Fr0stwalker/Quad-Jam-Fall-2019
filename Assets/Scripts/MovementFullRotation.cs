using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementFullRotation : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float rotationSpeed;

    public bool stop;
    void Update()
    {
        if (Input.GetKey(KeyCode.RightArrow) || Input.GetKey(KeyCode.D))
        {
            transform.eulerAngles = new Vector3(0, transform.eulerAngles.y + (Input.GetAxis("Horizontal") * Time.deltaTime * rotationSpeed), 0);
        }
        else if (Input.GetKey(KeyCode.LeftArrow) || Input.GetKey(KeyCode.A))
        {

            transform.eulerAngles = new Vector3(0, transform.eulerAngles.y + (Input.GetAxis("Horizontal")*Time.deltaTime*rotationSpeed), 0);
        }
        if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), .5f))
        {
            stop = true;
        }
        else if (stop)
        {
            stop = false;
        }
        if (!stop)
        {
            transform.Translate(Time.deltaTime * speed * Vector3.forward);

        }
    }

    private void FixedUpdate()
    {
        //transform.position = new Vector3(Mathf.Round(transform.position.x * 10) / 10, 0, Mathf.Round(transform.position.z * 10) / 10);
    }
}
