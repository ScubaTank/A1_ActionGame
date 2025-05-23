using UnityEngine;

public class GameOverState : BaseState
{
        private GameStateManager _context;

    public GameOverState(GameStateManager context)
    {
        _context = context;
    }

    public override void Enter()
    {
        Debug.Log("Entering GameOver State");
    }

    public override void Exit()
    {
        Debug.Log("Exiting GameOver State");
    }

    public override void Update()
    {

    }

    public override void FixedUpdate()
    {
        
    }
}
