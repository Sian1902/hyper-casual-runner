using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public Transform player; // Reference to the player's transform
    public float smoothSpeed = 0.125f; // Speed of camera movement

    private Vector3 offset; // Offset between camera and player

    void Start()
    {
        // Calculate the initial offset between camera and player
        offset = transform.position - player.position;
    }

    void LateUpdate()
    {
        // Calculate the target position for the camera
        Vector3 targetPosition = player.position + offset;

        // Smoothly interpolate the camera's position towards the target position
        Vector3 smoothedPosition = Vector3.Lerp(transform.position, targetPosition, smoothSpeed * Time.deltaTime);

        // Update the camera's position
        transform.position = smoothedPosition;
    }
}
