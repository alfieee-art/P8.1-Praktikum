public enum PlayerState { Idle, Running, Jumping, Falling, Dead }
public class PlayerStateMachine
{
    public PlayerState State { get; private set; } = PlayerState.Idle;
    
    public void Update(bool isMoving, bool jumpPressed, bool isGrounded, float
verticalVelocity, int health)
    {
        if (health <= 0) { State = PlayerState.Dead; return; }

        switch (State)
        {
            case PlayerState.Idle:
                if (jumpPressed) State = PlayerState.Jumping;
                else if (isMoving) State = PlayerState.Running;
                break;

            case PlayerState.Running:
                if (jumpPressed) State = PlayerState.Jumping;
                else if (!isMoving) State = PlayerState.Idle;
                break;

            case PlayerState.Jumping:
                if (verticalVelocity < 0) State = PlayerState.Falling;
                break;

            case PlayerState.Falling:
                if (isGrounded) State = PlayerState.Idle;
                break;
        }
    }
}