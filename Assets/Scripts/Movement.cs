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
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                transform.eulerAngles = new Vector3(0, 0, 0);
            }
            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                transform.eulerAngles = new Vector3(0, 180, 0);
            }
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                transform.eulerAngles = new Vector3(0, 270, 0);
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow))
            {
                transform.eulerAngles = new Vector3(0, 90, 0);
            }
            if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), 1f))
            {
                transform.position=new Vector3(Mathf.Round(transform.position.x),0,Mathf.Round(transform.position.z));
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
}
