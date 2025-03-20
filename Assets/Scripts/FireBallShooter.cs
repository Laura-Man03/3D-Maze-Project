using System.Collections;
using UnityEngine;

public class FireBallShooter : MonoBehaviour
{
    public GameObject fireballPrefab;
    public float spawnTimer = 1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        StartCoroutine(SpawnFireballRoutine());
    }

    private IEnumerator SpawnFireballRoutine()
    {
        while (true)
        {
            yield return new WaitForSeconds(spawnTimer);
            //will create an instance of the fireball
            Instantiate(fireballPrefab, transform.position, transform.rotation);
        }
    }
}
