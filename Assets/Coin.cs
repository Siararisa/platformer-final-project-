using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            PlayerScore ps = collision.gameObject.GetComponent<PlayerScore>();
            ps.AddScore(1);
            Destroy(this.gameObject);
        }
    }
}
