using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerMovement : MonoBehaviour
{
    public int health = 100;
    public float speed = 4.5f; //use f as a unit in floats for a point value
    public string hero = "Steve"; 
    public bool isAlive = true;
    public Vector3 direction; //XYZ coords
    
    void Start()
    {
        Debug.Log("My name is " + hero);
       
    }

    void Update()
    {
        transform.Translate(direction * Time.deltaTime * speed);
            //the . is there to access the function of transform
    }
    
    private void OnMove(InputValue value)
    {
        //Asks the input system what keys are being pressed
        Vector2 inputValue = value.Get<Vector2>();
        direction = new Vector3(inputValue.x, 0, inputValue.y);
    }
   
}