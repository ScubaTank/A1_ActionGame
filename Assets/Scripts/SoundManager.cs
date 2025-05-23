using UnityEngine;
using UnityEngine.Audio;

public class SoundManager : MonoBehaviour
{

    [SerializeField] private HealthController m_healthController;
    [SerializeField] private AudioResource m_hitSound;
    [SerializeField] private AudioResource m_deathSound;

    private AudioSource _audioSource;


    void Awake()
    {
        _audioSource = GetComponent<AudioSource>();
    }
    void OnEnable()
    {
        m_healthController.OnHealthUpdated += OnHealthUpdated;        
    }

    void OnDisable()
    {
        m_healthController.OnHealthUpdated -= OnHealthUpdated;  
    }

    private void OnHealthUpdated(float currHealth, float fullHealth, float dmgTaken){
        _audioSource.resource = m_hitSound;

        if(currHealth <= 0){
            _audioSource.resource = m_deathSound;
        }

        _audioSource.Play();
    }
}
