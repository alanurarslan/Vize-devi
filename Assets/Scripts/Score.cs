using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    [SerializeField] Text scoreText;
    public int score = 0;

    private void Start()
    {
        SkorSay();
    }

    public void SkorEkle(int x)
    {
        score += x;

        if (score < 0)
        {
            score = 0;
        }
       
        print(score);
        SkorSay();
    }

    void SkorSay()
    {
        scoreText.text = score.ToString();
    }

    
}

