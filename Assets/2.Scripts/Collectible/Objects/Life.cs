using UnityEngine;

public class Life : Collectible, IEffect/*, IGiveLife*/
{
    [SerializeField] GameObject effect;

    private void Awake()
    {
        effect.SetActive(false);
    }

    private void Start()
    {
        lifeToGive = 50;

        Debug.Log("Vida Life: " + lifeToGive);
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
