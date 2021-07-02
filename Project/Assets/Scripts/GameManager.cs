using UnityEngine.UI;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //** VARIABLES */

    // Reference to the Ball
    public Ball ball;

    // Reference to the Paddles
    public Paddle playerPaddle;
    public Paddle computerPaddle;

    // Reference to Text for score Ui
    public Text playerScoreText;
    public Text computerScoreText;

    // Player score
    private float _playerScore;

    // Computer score
    private float _computerScore;

    //** FUNCTIONS */

    // Player has scored
    public void PlayerScores()
    {
        _playerScore++;

        playerScoreText.text = _playerScore.ToString();
        ResetRound();

        // Debug.Log(_playerScore);
    }

    // Computer has scored
    public void ComputerScores()
    {
        _computerScore++;

        computerScoreText.text = _computerScore.ToString();
        ResetRound();

        // Debug.Log(_computerScore);
    }

    private void ResetRound()
    {
        ball.ResetPosition();
        playerPaddle.ResetPosition();
        computerPaddle.ResetPosition();
        ball.AddStartingForce();
    }
}
