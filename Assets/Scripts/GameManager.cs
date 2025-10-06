using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Transform playerPaddle;
    public Transform enemyPaddle;
    
    public BallController ballController;

    public int playerScore = 0;
    public int enemyScore = 0;

    public TextMeshProUGUI playerScoreText;
    public TextMeshProUGUI enemyScoreText;

    public int winningScore = 3;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ResetGame();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ResetGame()
    {
        playerPaddle.position = new Vector3(playerPaddle.position.x, 0, 0);
        enemyPaddle.position = new Vector3(enemyPaddle.position.x, 0, 0);
        ballController.ResetBall();
        playerScore = 0;
        enemyScore = 0;
        playerScoreText.text = playerScore.ToString();
        enemyScoreText.text = enemyScore.ToString();
    }

    public void PlayerScores()
    {
        playerScore++;
        playerScoreText.text = playerScore.ToString();
        CheckWin();
    }

    public void EnemyScores()
    {
        enemyScore++;
        enemyScoreText.text = enemyScore.ToString();
        CheckWin();
    }
    public void CheckWin()
        {
        if (playerScore >= winningScore)
        {
            Debug.Log("YOU WIN!");
            ResetGame();
        }
        else if (enemyScore >= winningScore)
        {
            Debug.Log("YOU LOSE!");
            ResetGame();
        }
    }
}
