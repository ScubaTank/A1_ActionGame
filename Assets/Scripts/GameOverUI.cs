using UnityEngine;

public class GameOverUI : MonoBehaviour
{

    [SerializeField] private HealthController m_healthController;

    private Canvas _gameOverCanvas;
    void Awake()
    {
        _gameOverCanvas = GetComponent<Canvas>();
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
        if(currHealth <= 0 && !_gameOverCanvas.enabled){
            _gameOverCanvas.enabled = true;
        }
    }
}
