using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Collectibles", menuName = "Collectibles", order = 1)]
public class Collectibles : ScriptableObject
{
    public List<Collectible> CollectibleList => collectibleList;

    [SerializeField] private List<Collectible> collectibleList = new List<Collectible>();

}
