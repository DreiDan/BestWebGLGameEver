using UnityEngine;
using UnityEngine.SceneManagement;
class SceneManagerScript : MonoBehaviour
{
    public static void NextSceneButton(int SceneID) => SceneManager.LoadScene(SceneID);
    private void Awake() => PlayerBall.Text = "";
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            ScoreManager.WText.text = "";
            NextSceneButton(0);
        }
    }
}
