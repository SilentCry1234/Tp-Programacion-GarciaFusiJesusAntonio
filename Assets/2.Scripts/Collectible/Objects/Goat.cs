using UnityEngine;

public class Goat : Collectible, ISound, IEffect
{
    public AudioSource GoatSound => goatSound; 

    [SerializeField] private GameObject effect;
    [SerializeField] private AudioSource goatSound;

    private float timeDestroySelf = 1f; 

    private void Awake()
    {
        lifeToGive = 50;

        effect.SetActive(false);
    }

    private void Start()
    {
        Destroy(this, timeDestroySelf);
    }

    public void Execute()
    {
        Instantiate(effect, transform.position, Quaternion.identity); 
    }

    public void MakeSound(AudioSource sound)
    {
        sound.Play();
    }
}
