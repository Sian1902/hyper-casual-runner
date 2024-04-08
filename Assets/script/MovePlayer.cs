using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePlayer : MonoBehaviour
{
    private Rigidbody rbPlayer;
    [SerializeField] private Joystick joystick;
    [SerializeField] private float sideWaySpeed;
    [SerializeField] private float forwardSpeed;
    [SerializeField] private Vector2 minMaxXpos;

    private void Awake()
    {
        rbPlayer = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        transform.position = new Vector3(Mathf.Clamp(transform.position.x, minMaxXpos.x, minMaxXpos.y),transform.position.y, transform.position.z);
        rbPlayer.velocity = new Vector3(joystick.Horizontal * sideWaySpeed , rbPlayer.velocity.y, forwardSpeed );
    }
}
