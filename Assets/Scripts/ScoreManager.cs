using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ScoreManager : MonoBehaviour
{
    // Start is called before the first frame update

     int currentScore = 0;
    int ScorePerDestroyed = 100;

     [SerializeField]Text ScoreText;



    void Start() => GetComponent<Text>().text = currentScore.ToString();
    void Update()
    {
      
    }

    public void AddtoScore()
    {
        currentScore += ScorePerDestroyed;
        ScoreText.text = currentScore.ToString();

    }
}
