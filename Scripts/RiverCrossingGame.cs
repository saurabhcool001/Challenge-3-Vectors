using UnityEngine;

public class RiverCrossingGame : MonoBehaviour
{
    // Character movement speed
    public float moveSpeed = 5f;

    // River current speed and direction
    public Vector3 riverCurrent = new Vector3(1f, 0, 0);

    // Reference to the player's Transform
    public Transform player;

    void Update()
    {
        // Get input from keyboard (WASD or Arrow Keys)
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");

        // Create a movement vector based on input
        Vector3 playerInput = new Vector3(inputX, inputY, 0);

        // Normalize the input vector for consistent speed
        playerInput = VectorOperations.Normalize(playerInput);

        // Multiply the normalized vector by moveSpeed
        Vector3 movement = VectorOperations.MultiplyByScalar(playerInput, moveSpeed * Time.deltaTime);

        // Add the river current to the player's movement
        Vector3 totalMovement = VectorOperations.Add(movement, VectorOperations.MultiplyByScalar(riverCurrent, Time.deltaTime));

        // Apply the total movement to the player's position
        player.position = VectorOperations.Add(player.position, totalMovement);
    }

    void OnDrawGizmos()
    {
        if (player != null)
        {
            // Draw the river current as a red arrow
            Gizmos.color = Color.red;
            Gizmos.DrawLine(player.position, player.position + riverCurrent);
        }
    }
}
