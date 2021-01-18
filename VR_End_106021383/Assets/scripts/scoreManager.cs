using UnityEngine;
using UnityEngine.UI;

public class scoreManager : MonoBehaviour
{
    [Header("分數介面")]
    public Text textScore;
    [Header("分數")]
    public int score;


    public  void Addscore() 
    {
        score += 1;
        textScore.text = "分數:" + score;
    }


}
