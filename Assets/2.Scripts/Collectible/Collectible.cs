using UnityEngine;

public class Collectible : MonoBehaviour
{
    public int PointToGive => pointsToGive; 
    public int LifeToGive => lifeToGive;

    protected int pointsToGive;
    protected int lifeToGive;
}
