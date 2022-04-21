using UnityEngine;
using System.Collections;
using System.Collections.Generic;
class PlayerBall : MonoBehaviour
{
    Rigidbody Rb;
    [SerializeField] int Speed;
    public static string Text;
    public static float Time;
    public static List<float> BackResult = new List<float>();
    void Awake()
    {
        Rb = GetComponent<Rigidbody>();
        StartCoroutine(TimeFlow());
    }
    void Movement()
    {
        float MoveRL = Input.GetAxis("Horizontal");
        float MoveUD = Input.GetAxis("Vertical");
        Vector3 Move = new Vector3(MoveRL, 0.0f, MoveUD);
        Rb.AddForce(Move * Speed);
    }
    void FixedUpdate() => Movement();
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Finish"))
        {
            SceneManagerScript.NextSceneButton(2);
            Text = "Вы выиграли " + Time;
            BackResult.Add(Time);
        }
        if (other.CompareTag("Hole"))
        {
            SceneManagerScript.NextSceneButton(2);
            Text = "Вы проиграли";
        }
        Time = 0;
    }
    IEnumerator TimeFlow()
    {
        while (true)
        {
            Time++;
            yield return new WaitForSeconds(1);
        }
    }
}
