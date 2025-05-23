using UnityEngine;

public class Bullet : MonoBehaviour
{

    [SerializeField] private float m_BulletDamage;

    void OnCollisionEnter(Collision collision)
    {
        var healthController = collision.gameObject.GetComponent<HealthController>();

        if(healthController != null){
            healthController.TakeDamage(m_BulletDamage);
        }
    }
}
