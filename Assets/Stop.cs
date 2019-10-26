using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stop : MonoBehaviour
{
    [SerializeField] private bool canGoLeft;
    [SerializeField] private bool canGoRight;
    [SerializeField] private bool canGoUp;
    [SerializeField] private bool canGoDown;
    [SerializeField] private bool triggerArmed=true;
    private GameObject player;
    private bool playerInStopZone;
    private void OnTriggerStay(Collider other)
    {
        if (triggerArmed)
        {
            if (other.CompareTag("Player"))
            {
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
            if (Input.GetKeyDown(KeyCode.UpArrow) && canGoUp)
            {
                playerInStopZone = false;
                player.transform.eulerAngles=new Vector3(0,270,0);
                player.GetComponent<Movement>().stop = false;
            }

            else if (Input.GetKeyDown(KeyCode.RightArrow) && canGoRight)
            {
                playerInStopZone = false;
                player.transform.eulerAngles = new Vector3(0, 0, 0);
                player.GetComponent<Movement>().stop = false;
            }
            else if (Input.GetKeyDown(KeyCode.LeftArrow) && canGoLeft)
            {
                playerInStopZone = false;
                player.transform.eulerAngles = new Vector3(0, 180, 0);
                player.GetComponent<Movement>().stop = false;
            }
            else if (Input.GetKeyDown(KeyCode.DownArrow) && canGoDown)
            {
                playerInStopZone = false;
                player.transform.eulerAngles = new Vector3(0, 90, 0);
                player.GetComponent<Movement>().stop = false;
            }
            Debug.Log("Can move");
        }
    }
}
