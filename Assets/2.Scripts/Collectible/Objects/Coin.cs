using UnityEngine;

public class Coin : Collectible, ISound
{
    public AudioSource CoinSound => coinSound;

    [SerializeField] AudioSource coinSound;

    private float timeDestroySelf = 1f;

    private void Start()
    {
        pointsToGive = 10;

        Debug.Log("Puntos Coin: " + pointsToGive);

        //Destroy(this, timeDestroySelf);
    }

    public void MakeSound(AudioSource sound)
    {
        sound.Play();
    }

    //Tener un controlador de audio para poder manejar desde ahi todos los audios y no tener muchos audiosource
    //Tener un bool para que se vea cuando se ha agarrado el objeto
}
