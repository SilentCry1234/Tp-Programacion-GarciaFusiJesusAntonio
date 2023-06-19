using System;
using Unity.VisualScripting;
using UnityEngine;

public class Life : Collectible, IEffect/*, IGiveLife*/
{
    private float timeDestroySelf = 1f; 

    [SerializeField] GameObject effect;

    //int IGiveLife.LifeToGive => lifeToGive;

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
        effect.SetActive(true);
    }

    //public void GiveLife()
    //{
    //    Debug.Log(lifeToGive);
    //}
}
