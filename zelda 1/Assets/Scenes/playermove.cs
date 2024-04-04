using UnityEngine;

public class zelda1 : MonoBehaviour
{
    public float speed = 5f; // Adjust the speed as needed

    void FixedUpdate()
    {
        // Get input from Unity's Input system
        float xDirection = Input.GetAxis("horizontal");
        float zDirection = Input.GetAxis("vertical");

        // Create a movement vector based on input
        Vector3 moveDirection = new Vector3(xDirection, 0.0f, zDirection);

        // Normalize the movement vector to maintain constant speed diagonally
        moveDirection.Normalize();

        // Move the object based on input and speed
        transform.position += moveDirection * speed * Time.fixedDeltaTime;
    }
}
