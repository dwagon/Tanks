using UnityEngine;

public class TankFiring : MonoBehaviour
{
    [SerializeField] GameObject m_shell;
    [SerializeField] GameObject m_firingLocation;
    [SerializeField] float m_firingVelocity;


    void OnAttack()
    {
        GameObject m_shellInstance;
        Rigidbody m_shellRigid;
        m_shellInstance = Instantiate(m_shell, m_firingLocation.transform.position, m_firingLocation.transform.rotation);
        m_shellRigid = m_shellInstance.GetComponent<Rigidbody>();
        m_shellRigid.linearVelocity = m_firingVelocity * m_firingLocation.transform.forward;
    }
}
