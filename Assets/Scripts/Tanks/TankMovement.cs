using System;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering.PostProcessing;

public class TankMovement : MonoBehaviour
{

    [Header("Movement")]
    [SerializeField] float movementSpeed = 1f;
    [SerializeField] float rotateSpeed = 10f;

    InputAction m_moveAction;
    float rotation;
    float speed;
    Rigidbody m_rigidBody;

    void Start()
    {
        m_moveAction = InputSystem.actions.FindAction("Move");
        m_rigidBody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Move();
        Turn();
    }

    void Turn()
    {
        rotation = m_moveAction.ReadValue<Vector2>().x * rotateSpeed * Time.deltaTime;
        m_rigidBody.MoveRotation(m_rigidBody.rotation * Quaternion.Euler(0f, rotation, 0f));
    }

    void Move()
    {
        speed = m_moveAction.ReadValue<Vector2>().y * movementSpeed;
        Vector3 movement = speed * transform.forward;

        m_rigidBody.linearVelocity = movement;
    }

}
