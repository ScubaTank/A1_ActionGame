using UnityEngine;
using UnityEngine.UI;

public class HealthBarUI : MonoBehaviour
{
    [SerializeField] private HealthController m_healthController;

    private Image _healthBarImage;

    void Awake()
    {
        _healthBarImage = GetComponent<Image>();
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
        _healthBarImage.fillAmount = currHealth/fullHealth;
    }

}
