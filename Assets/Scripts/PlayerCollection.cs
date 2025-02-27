using UnityEngine;

public class PlayerCollection : MonoBehaviour
{
   //shortcut of OTE for ontriggerenter
   private void OnTriggerEnter(Collider other)
   {
      //only destroy if collectable
      if (other.CompareTag("Collatable"))
      {
         Destroy(other.gameObject);
      }
      
   }
}
