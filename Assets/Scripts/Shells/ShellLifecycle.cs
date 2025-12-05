using System.Collections;
using UnityEngine;

public class ShellLifecycle : MonoBehaviour
{
    [SerializeField] float shellLifetime = 5f;

    [Header("Explosion")]
    [SerializeField] GameObject m_explosion;

    void Start()
    {
        Destroy(gameObject, shellLifetime);

    }

    void OnCollisionEnter(Collision other)
    {
        GameObject explosion = Instantiate(m_explosion);
        ParticleSystem m_explosionParticles = explosion.GetComponent<ParticleSystem>();
        m_explosionParticles.transform.position = transform.position;
        m_explosionParticles.Play(true);
        var main = m_explosionParticles.main;
        Destroy(explosion, main.duration);
        Destroy(gameObject);
    }


}
