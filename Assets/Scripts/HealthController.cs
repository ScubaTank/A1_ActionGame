using System;
using UnityEngine;
using UnityEngine.UI;

public class HealthController : MonoBehaviour
{
    [SerializeField] private float m_fullHealth;
    private float _health;

    public event Action<float, float, float> OnHealthUpdated; //currHealth, FullHealth, DamageTaken
    

    void Start()
    {
        _health = m_fullHealth;
    }

    public void TakeDamage(float damage){
        _health -= damage;
        OnHealthUpdated?.Invoke(_health, m_fullHealth, damage);

    }
}
