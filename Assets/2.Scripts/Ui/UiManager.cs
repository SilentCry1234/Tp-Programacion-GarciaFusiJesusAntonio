using UnityEngine;
using UnityEngine.UI;

public class UiManager : MonoBehaviour
{
    [SerializeField] private Text scoreText;
    [SerializeField] private Text healthText;

    private Player player;
    
    private void Awake()
    {
        FindPlayer();
    }

    private void Update()
    {
        ShowScore();
        ShowHealth();
    }

    private void FindPlayer()
    {
        player = FindObjectOfType<Player>();
    }

    private void ShowScore()
    {
        scoreText.text = player.Score.ToString();
    }

    private void ShowHealth()
    {
        healthText.text = player.Health.ToString();
    }
}
