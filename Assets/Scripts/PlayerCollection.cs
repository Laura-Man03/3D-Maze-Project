using TMPro;
using UnityEngine;

public class PlayerCollection : MonoBehaviour
{
   private int score = 0;
   public TMP_Text scoreText;
   
   //shortcut of OTE for ontriggerenter
   private void OnTriggerEnter(Collider other)
   {
      //only destroy if collectable
      if (other.CompareTag("Collatable"))
      {
         AddScore(1);
         Destroy(other.gameObject);
      }
   }

   private void AddScore(int points)
   {
      score = score + points;
      scoreText.text = $"<b>Score:</b> {score}";
   }
}
