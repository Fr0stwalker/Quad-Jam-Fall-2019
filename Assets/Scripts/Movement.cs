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
        if (!stop)
        {
            transform.Translate(Time.deltaTime * speed * Vector3.forward);
            if (transform.eulerAngles.y == 0 || transform.eulerAngles.y == 180)
            {
                if (Input.GetKeyDown(KeyCode.RightArrow))
                {
                    transform.eulerAngles = new Vector3(0, 0, 0);
                }
                else if (Input.GetKeyDown(KeyCode.LeftArrow))
                {
                    transform.eulerAngles = new Vector3(0, 180, 0);
                }
            }
            else
            {
                if (Input.GetKeyDown(KeyCode.UpArrow))
                {
                    transform.eulerAngles = new Vector3(0, 270, 0);
                }
                else if (Input.GetKeyDown(KeyCode.DownArrow))
                {
                    transform.eulerAngles = new Vector3(0, 90, 0);
                }
            }
        }
    }
}
