using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBallDudes : MonoBehaviour
{
    [SerializeField] private LayerMask m_LayerMask;

    [SerializeField] private GameObject ballDude;

    [SerializeField] private float spawnTimer=5f;

    private float timeSinceLastSpawn=Mathf.Infinity;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (spawnTimer <= timeSinceLastSpawn)
        {
            timeSinceLastSpawn = 0f;
            Collider[] hitColliders = Physics.OverlapBox(gameObject.transform.position, transform.localScale / 2,
                Quaternion.identity, m_LayerMask);
            if (hitColliders.Length != 0)
            {
                Debug.Log("Can't spawn things " + hitColliders.Length);
            }
            else
            {
                Instantiate(ballDude, transform.position, Quaternion.identity);
            }
        }

        timeSinceLastSpawn += Time.deltaTime;
    }

    private void OnDrawGizmos()
    {
        Gizmos.color=Color.red;
        Gizmos.DrawWireCube(transform.position,transform.localScale);
    }
}
