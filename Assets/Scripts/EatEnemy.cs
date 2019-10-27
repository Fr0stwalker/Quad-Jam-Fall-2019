using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EatEnemy : MonoBehaviour
{
    [SerializeField] private int scoreAwardedToPlayer=50;
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            Score score = FindObjectOfType<Score>();
            score.SetScore(scoreAwardedToPlayer);
            Destroy(gameObject);
        }
    }
}
