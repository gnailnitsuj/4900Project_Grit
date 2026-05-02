using UnityEngine;

public class TreeCollision : MonoBehaviour
{
    void Awake()
    {
        GetComponent<TerrainCollider>().enabled = false;
        GetComponent<TerrainCollider>().enabled = true;
    }
}
