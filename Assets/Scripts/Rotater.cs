using UnityEngine;

public class Rotater : MonoBehaviour
{
    public float speed = 45;
    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.up, speed * Time.deltaTime);
    }
}
