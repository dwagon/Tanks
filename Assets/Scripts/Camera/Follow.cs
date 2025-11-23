using UnityEngine;
using UnityEngine.InputSystem;

public class Follow : MonoBehaviour
{
    Camera m_camera;

    void Start()
    {
        m_camera = Camera.main;
    }

    void Update()
    {
        m_camera.transform.LookAt(transform);
    }
}
