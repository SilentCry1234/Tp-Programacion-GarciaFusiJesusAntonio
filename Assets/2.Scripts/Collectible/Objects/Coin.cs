using UnityEngine;

public class Coin : Collectible, ISound
{
    public AudioSource CoinSound => coinSound;

    [SerializeField] AudioSource coinSound;

    private float timeDestroySelf = 1f;
     
    private void Awake()
    {
        pointsToGive = 10; 
    }

    private void Start()
    {
        Destroy(gameObject, timeDestroySelf);
    }

    public void MakeSound(AudioSource sound)
    {
        sound.Play();
    }
    
}
