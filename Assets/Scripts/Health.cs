using UnityEngine;

public class Health : MonoBehaviour
{
    public int points = 5;
    private PlayerMovement playerMovement;

    private void Start()
    {
        playerMovement = GetComponent<PlayerMovement>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Trap")) //we are activating trap 
        {
            Damage(1);
        }
    }
    //Instead of destroying the player, it resets the health points and moves the player to the starting position
    private void Damage(int value)
    {
        points -= value;
        if (points < 1)
        {
            ResetHealth();//reset health
            playerMovement.ResetPlayer(); // Move player to start 
        }
    }
    //points go back to 5
    public void ResetHealth()
    {
        points = 5;
    }
}