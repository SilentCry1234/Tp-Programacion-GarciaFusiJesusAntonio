using System.Collections;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int Score => score;
    public int Health => health;

    private int score;
    private int health;

    private Collectible pickCurrentCollectible;

    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Me estoy activando"); 

        if (other.gameObject.CompareTag("PickObject"))
        {
            if (other.TryGetComponent<Collectible>(out var collectible))
            {
                pickCurrentCollectible = collectible;

                //collectible.GiveLife();

                StartCoroutine(SumValuesandDestroyObjects());
            }
        }
    }

    private void Collect(Collectible go)
    {
        //Debug.Log(go.LifeToGive);

        ScoreSum(go.LifeToGive);
        HealthSum(go.PointToGive);
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

    private void DoSound(AudioSource sound)
    {
        sound.Play();
    }

    IEnumerator SumValuesandDestroyObjects()
    {
        Collect(pickCurrentCollectible);

        yield return new WaitForSeconds(3f);

        Destroy(pickCurrentCollectible.gameObject);
    }
}
