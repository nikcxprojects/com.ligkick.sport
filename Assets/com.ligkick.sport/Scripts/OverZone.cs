using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OverZone : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.CompareTag("ball"))
        {
            return;
        }

        GameManager.Instance.EndGame();
    }
}