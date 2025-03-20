using UnityEngine;
using TMPro;

public class Health : MonoBehaviour
{
    public int points = 5;
    private Vector3 respawnPosition;
    public TextMeshProUGUI healthText;
    public EndScreenAnimation gameOverScreen;
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
        
        if (other.CompareTag("Fireball")) //we are activating trap 
        {
            Damage(2);
            Destroy(other.gameObject);
        }

        if (other.CompareTag("Checkpoint"))
        {
            respawnPosition = other.transform.position;
            respawnPosition.y = transform.position.y;
        }
    }
    //Instead of destroying the player, it resets the health points and moves the player to the starting position
    private void Damage(int value)
    {
        points -= value;
        //$ is used to help with value of points
        healthText.text = $"<b>Health:</b> {points}";
        transform.position = respawnPosition;
        //points = 5;
        
        if (points < 1)
        {
            gameOverScreen.StartFade();
            Destroy(gameObject);
        }
    }
    
}