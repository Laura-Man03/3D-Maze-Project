using UnityEngine;

public class Health : MonoBehaviour
{
    public int points = 5;
    private Vector3 respawnPosition;

    private void Start()
    {
       respawnPosition = transform.position;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Trap")) //we are activating trap 
        {
            Damage(1);
        }

        if (other.CompareTag("Checkpoint"))
        {
            respawnPosition = transform.position;
        }
    }
    //Instead of destroying the player, it resets the health points and moves the player to the starting position
    private void Damage(int value)
    {
        points -= value;
        if (points < 1)
        {
            //Destroy(gameObject);
           transform.position = respawnPosition;
           points = 5;
        }
    }
    
}