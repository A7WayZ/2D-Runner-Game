using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TimeManager : MonoBehaviour
{

    public TextMeshProUGUI TextPoint;
    public TextMeshProUGUI TextHighscore;

    private float _timeInLevel;
    private bool _runTimer = true;

    // Start is called before the first frame update

    void Start()
    {

        string score = "Highscore: "+PlayerPrefs.GetFloat("Highscore").ToString("F1");
        TextHighscore.text = score;
        
    }

    // Update is called once per frame
    void Update()
    {
   
        if (_runTimer == true) { 
        _timeInLevel += Time.deltaTime;
        
       }

        TextPoint.text = "Point: " + _timeInLevel.ToString("F1");

       

    }

    public void StopAndSaveScore()
    {

        _runTimer = false;

        float lastScore = PlayerPrefs.GetFloat("Highscore");
        if (lastScore < _timeInLevel)
        {

            PlayerPrefs.SetFloat("Highscore", _timeInLevel);
        }

        }

}
