using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float speed;

    public bool stop;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
            if (Input.GetKeyDown(KeyCode.RightArrow) && !Physics.Raycast(transform.position, transform.TransformDirection(Vector3.right), .7f))
            {
                transform.eulerAngles = new Vector3(0, transform.eulerAngles.y+90f, 0);
            }
            else if (Input.GetKeyDown(KeyCode.LeftArrow) && !Physics.Raycast(transform.position, transform.TransformDirection(Vector3.left), .7f))
            {
                transform.eulerAngles = new Vector3(0, transform.eulerAngles.y - 90f, 0);
            }
            //if (Input.GetKeyDown(KeyCode.UpArrow))
            //{
            //    transform.eulerAngles = new Vector3(0, transform.eulerAngles.y + 180f, 0);
            //}
            else if (Input.GetKeyDown(KeyCode.DownArrow) && !Physics.Raycast(transform.position, transform.TransformDirection(Vector3.back), .7f))
            {
                transform.eulerAngles = new Vector3(0, transform.eulerAngles.y -180f, 0);
            }
            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), .7f))
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
        transform.position = new Vector3(Mathf.Round(transform.position.x*10)/10, 0, Mathf.Round(transform.position.z *10)/10);
    }
}
