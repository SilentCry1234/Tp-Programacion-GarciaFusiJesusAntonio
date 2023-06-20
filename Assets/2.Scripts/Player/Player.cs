using System.Collections;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int Score => score;
    public int Health => health;

    private int score;
    private int health;

    [SerializeField]
    Coin coin;
    [SerializeField]
    Goat goat;
    [SerializeField]
    Life life; 

    private float timerCounter; 

    private Collectible pickCurrentCollectible;

    private void Update()
    {
        timerCounter = Time.deltaTime;   
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("PickObject"))
        {
            if (other.TryGetComponent<Collectible>(out var collectible))
            {
                //Debug.Log("Estoy agarrando el objeto");
                pickCurrentCollectible = collectible;

                StartCoroutine(SumValuesandDestroyObjects()); 
            }
        }
    }

    private void Collect(Collectible go)
    {
        ScoreSum(go.PointToGive);
        HealthSum(go.LifeToGive);

        DoSoundCoin(coin.CoinSound);

        LifeEffect();

        GoatEffectandSoun(goat.GoatSound); 
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

    private void DoSoundCoin(AudioSource sound)
    {
        coin.MakeSound(sound);
    }

    private void LifeEffect()
    {
        life.Execute();
    }

    private void GoatEffectandSoun(AudioSource sound)
    {
        goat.MakeSound(sound);
        goat.Execute();
    }

    IEnumerator SumValuesandDestroyObjects()
    {
        Collect(pickCurrentCollectible);

        yield return new WaitForSeconds(4f);

        Destroy(pickCurrentCollectible.gameObject);
    }
}
