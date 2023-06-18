using UnityEngine;

public class Goat : Collectible, ISound, IEffect
{
    [SerializeField] private GameObject effect; 

    private AudioSource goatSound;

    private float timeDestroySelf = 1; 

    private void Awake()
    {
        lifeToGive = 50;

        effect.SetActive(false);
    }

    private void Start()
    {
        Destroy(gameObject, timeDestroySelf);
    }

    public void Execute()
    {
        effect.SetActive(true); 
    }

    public void MakeSound(AudioSource sound)
    {
        sound.Play();
    }
}
