using System;
using UnityEngine;

public class Health : MonoBehaviour
{
    public int points = 5;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Trap"))
        {
            Damage(1);
        }
    }

    //to remove some health points
    private void Damage(int value)
    {
        points = points - value;
        if (points < 1)
        {
            //move player to start and reset points = 5
            Destroy(gameObject);
        }
    }
}
