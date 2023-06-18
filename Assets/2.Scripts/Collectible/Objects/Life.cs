using System;
using Unity.VisualScripting;
using UnityEngine;

public class Life : Collectible, IEffect
{
    [DoNotSerialize] public GameObject Effect => effect;

    private float timeDestroySelf = 1; 

    [SerializeField] GameObject effect; 

    private void Awake()
    {
        lifeToGive = 20;

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
}
