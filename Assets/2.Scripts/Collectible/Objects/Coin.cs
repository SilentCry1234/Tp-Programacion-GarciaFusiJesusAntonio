using UnityEngine;

public class Coin : Collectible, ISound
{
    public AudioSource CoinSound => coinSound;

    [SerializeField] AudioSource coinSound;

    private void Awake()
    {
        pointsToGive = 10;
    }

    public void MakeSound(AudioSource sound)
    {
        sound.Play();
    }
}
