using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    PlayerScore score;

    private void Start()
    {
        score = GameObject.FindObjectOfType<PlayerScore>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            score.AddScore(1);
            Destroy(this.gameObject);
        }
    }
}
