using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stop : MonoBehaviour
{
    [SerializeField] private bool leftBlocked;
    [SerializeField] private bool rightBlocked;
    [SerializeField] private bool upBlocked;
    [SerializeField] private bool downBlocked;
    [SerializeField] private bool triggerArmed=true;
    private GameObject player;
    private bool playerInStopZone;
    private void OnTriggerStay(Collider other)
    {
        if (triggerArmed)
        {
            if (other.CompareTag("Player"))
            {
                if (other.transform.eulerAngles.y == 180 && !leftBlocked)
                {
                    return;
                }
                if (other.transform.eulerAngles.y == 270 && !upBlocked)
                {
                    return;
                }
                if (other.transform.eulerAngles.y == 0 && !rightBlocked)
                {
                    return;
                }
                if (other.transform.eulerAngles.y == 90 && !downBlocked)
                {
                    return;
                }
                if (other.transform.position.z <= transform.position.z)
                {
                    //StartCoroutine(MovePlayerToCenter());
                    other.transform.position = transform.position;
                    other.GetComponent<Movement>().stop = true;
                    playerInStopZone = true;
                    triggerArmed = false;
                    player = other.gameObject;
                }
            }
        }
    }

    //IEnumerator MovePlayerToCenter()
    //{

    //    yield return new WaitForSeconds();
    //}
    private void OnTriggerExit(Collider other)
    {
        triggerArmed = true;
    }

    private void Update()
    {
        if (playerInStopZone)
        {
            if (Input.GetKeyDown(KeyCode.UpArrow) && !upBlocked)
            {
                playerInStopZone = false;
                player.transform.eulerAngles=new Vector3(0,270,0);
                player.GetComponent<Movement>().stop = false;
            }

            else if (Input.GetKeyDown(KeyCode.RightArrow) && !rightBlocked)
            {
                playerInStopZone = false;
                player.transform.eulerAngles = new Vector3(0, 0, 0);
                player.GetComponent<Movement>().stop = false;
            }
            else if (Input.GetKeyDown(KeyCode.LeftArrow) && !leftBlocked)
            {
                playerInStopZone = false;
                player.transform.eulerAngles = new Vector3(0, 180, 0);
                player.GetComponent<Movement>().stop = false;
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow) && !downBlocked)
            {
                playerInStopZone = false;
                player.transform.eulerAngles = new Vector3(0, 90, 0);
                player.GetComponent<Movement>().stop = false;
            }
            Debug.Log("Can move");
        }
    }
}
