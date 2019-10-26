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
            if (Input.GetKeyDown(KeyCode.RightArrow) && !Physics.Raycast(transform.position, transform.TransformDirection(Vector3.right), .5f))
            {
                transform.eulerAngles = new Vector3(0, transform.eulerAngles.y+90f, 0);
            }
            else if (Input.GetKeyDown(KeyCode.LeftArrow) && !Physics.Raycast(transform.position, transform.TransformDirection(Vector3.left), .5f))
            {
            transform.eulerAngles = new Vector3(0, transform.eulerAngles.y - 90f, 0);
            }
            //if (Input.GetKeyDown(KeyCode.UpArrow))
            //{
            //    transform.eulerAngles = new Vector3(0, transform.eulerAngles.y + 180f, 0);
            //}
            else if (Input.GetKeyDown(KeyCode.DownArrow) && !Physics.Raycast(transform.position, transform.TransformDirection(Vector3.back), .5f))
            {
            transform.eulerAngles = new Vector3(0, transform.eulerAngles.y -180f, 0);
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
                //transform.position = new Vector3(Mathf.Round(transform.position.x), 0, Mathf.Round(transform.position.z));
            }
    }
}
