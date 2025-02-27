using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;
    public float transitionSpeed = 10;
    private Vector3 offset;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        offset = target.position - transform.position;
        //calculating the fixed position of the camera distance of the player
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 targetPosition = target.position - offset;
        transform.position = Vector3.Lerp(transform.position, targetPosition, transitionSpeed * Time.deltaTime);
        //Lerp = linear Interpolation, moving in a graph
    }
}
