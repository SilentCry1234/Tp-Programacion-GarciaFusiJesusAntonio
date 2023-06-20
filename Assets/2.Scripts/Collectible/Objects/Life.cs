using UnityEngine;

public class Life : Collectible, IEffect/*, IGiveLife*/
{
    private float timeDestroySelf = 1f; 

    [SerializeField] GameObject effect;

    //int IGiveLife.LifeToGive => lifeToGive;

    private void Awake()
    {
        effect.SetActive(false);
    }

    private void Start()
    {
        lifeToGive = 50;

        Debug.Log("Vida Life: " + lifeToGive);

        //Destroy(this, timeDestroySelf);
    }

    public void Execute()
    {
        effect.SetActive(true);
    }

    //public void GiveLife()
    //{
    //    Debug.Log(lifeToGive);
    //}
}
