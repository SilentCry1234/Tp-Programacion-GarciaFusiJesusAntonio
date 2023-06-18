using System;
using Unity.VisualScripting;
using UnityEngine;

public class Life : Collectible, IEffect
{
    private float timeDestroySelf = 1f; 

    [SerializeField] GameObject effect; 

    private void Awake()
    {
        lifeToGive = 20;

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
}
