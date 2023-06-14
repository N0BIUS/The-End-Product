using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public TextMeshProUGUI T;
    public static float score;
    public static int gold;

    public static bool alive;

    private void Start()
    {
        alive = true;
    }
    private void Update()
    {
        if (alive)
        {
            score += 1 * Time.deltaTime;
            T.text = "ќчки: " + ((int)score).ToString()+"\n«олотые €блоки: "+gold;
        }
    }

}
[System.Serializable]
public class Data 
{
    public static int scorenum ;
    public static int[] scores()
    {
        scorenum = PlayerPrefs.GetInt("scorenum");
        int[] scores = new int[scorenum];
        for (int i = 0; i < scores.Length; i++)
        {
            scores[i] = PlayerPrefs.GetInt("score_" + (i + 1));
        }
        return scores;

    }
    public static void SaveSC()
    {
        scorenum = PlayerPrefs.GetInt("scorenum");
        PlayerPrefs.SetInt("score_" + scorenum, (int)ScoreManager.score);
        PlayerPrefs.Save();
    }
}