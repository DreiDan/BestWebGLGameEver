using UnityEngine;

class Camera : MonoBehaviour
{
    GameObject Player;
    Vector3 Offset;
    void Awake()
    {
        Player = GameObject.Find("Player");
        Offset = transform.position - Player.transform.position;
    }
    void LateUpdate() => transform.position = Player.transform.position + Offset;
}
