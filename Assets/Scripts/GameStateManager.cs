using UnityEngine;
using UnityEngine.XR;

public class GameStateManager : MonoBehaviour
{
    private BaseState _currentState;
    private BaseState _previousState;

    public string CurrentStateName => _currentState?.GetType().Name;

    private void Start()
    {
        ChangeState(new MenuState(this));
    }

    private void Update()
    {
        _currentState?.Update();
    }

    private void FixedUpdate()
    {
        _currentState?.FixedUpdate();
    }

    public void ChangeState(BaseState newState)
    {
        _currentState?.Exit();
        _previousState = _currentState;
        _currentState = newState;
        _currentState?.Enter();
    }

    public void RevertToPreviousState()
    {
        if (_previousState != null)
        {
            ChangeState(_previousState);
        }
        else
        {
            Debug.LogWarning("No previous state available to revert to!");
        }
    }
}
