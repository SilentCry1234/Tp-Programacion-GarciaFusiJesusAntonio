using UnityEngine;

public class Goat : Collectible, ISound, IEffect/*, IGiveLife*/
{
    public AudioSource GoatSound => goatSound;

    //int IGiveLife.LifeToGive => lifeToGive;

    [SerializeField] private GameObject effect;
    [SerializeField] private AudioSource goatSound;

    private float timeDestroySelf = 1f; 

    private void Awake()
    {
        effect.SetActive(false);
    }

    private void Start()
    {
        lifeToGive = 20;

        Debug.Log("Vida Goat: " +  lifeToGive);

        //Destroy(this, timeDestroySelf);
    }

    public void Execute()
    {
        Instantiate(effect, transform.position, Quaternion.identity); 
    }

    public void MakeSound(AudioSource sound)
    {
        sound.Play();
    }

    //public void GiveLife()
    //{
    //    Debug.Log(lifeToGive + "Soy Cabra"); 
    //}
}
