using UnityEngine;

public class TargetPlayer : MonoBehaviour
{
    #region Singleton

    public static TargetPlayer instance;
     void Awake() {
        instance = this;
     }

    #endregion

    public GameObject player;
}
