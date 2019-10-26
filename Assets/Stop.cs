using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stop : MonoBehaviour
{

    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Debug.Log(other.transform.position);
            Debug.Log(transform.position);
            if (other.transform.position.z >= Mathf.Abs(transform.position.z))
            {
                other.transform.position = transform.position;
                other.GetComponent<Movement>().stop = true;
            }
        }
    }
}
