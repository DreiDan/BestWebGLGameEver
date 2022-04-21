using UnityEngine;
using UnityEngine.UI;
class ScoreManager : MonoBehaviour
{
    public static Text WText;
    public static Text RText;
    public static int sum = -1;
    private void Awake()
    {
        WText = GameObject.Find("Canvas/Panel/Text").GetComponent<Text>();
        RText = GameObject.Find("Canvas/Panel/Text1").GetComponent<Text>();
        WText.text = PlayerBall.Text;
        if (PlayerBall.BackResult[0] != 0)
        {
            RText.text = "";
            if (PlayerBall.BackResult[1] != 0)
            {
                sum++;
                RText.text = $"{PlayerBall.BackResult[sum]}";
            }
        }
    }

}
