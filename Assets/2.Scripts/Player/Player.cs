using UnityEngine;

public class Player : MonoBehaviour
{
    public int Score => score;
    public int Health => health;

    private int score;
    private int health;

    private Coin coin;
    private Goat goat;
    private Life life;

    private Collectible pickCurrentCollectible; 

    private void OnCollisionEnter(Collision other)
    {
        Debug.Log("I Hit " + other.collider.name);

        if(other.gameObject.CompareTag("PickObject"))
        {
            if(other.gameObject.TryGetComponent<Collectible>(out var collectible))
            {
                pickCurrentCollectible = collectible;

                Collect(pickCurrentCollectible); 
            }
        }
    }

    private void Collect(Collectible go)
    {
        Debug.Log("I'm being call"); 

        ScoreSum(go.PointToGive);
        HealthSum(go.LifeToGive);
    }

    private void ScoreSum(int points)
    {
        score += points; 
        Debug.Log("Eh sumado puntos " + score); 
    }

    private void HealthSum(int hearts)
    {
        health += hearts;
        Debug.Log("Me Cure " + health); 
    }
}
