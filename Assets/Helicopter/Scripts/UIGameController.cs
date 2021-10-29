using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UIGameController : MonoBehaviour
{
    public Text EngineForceView;


	// Use this for initialization
    public static UIGameController runtime;

    private void Awake()
    {
        runtime = this;
        PlayerPrefs.SetInt("Score", 0);
        EngineForceView.text = "Score : " + PlayerPrefs.GetInt("Score");
    }

   
    
    public void ScoreManager(int score) {

        PlayerPrefs.SetInt("Score", PlayerPrefs.GetInt("Score")+score);
        EngineForceView.text = "Score : " + PlayerPrefs.GetInt("Score");

    }

}
