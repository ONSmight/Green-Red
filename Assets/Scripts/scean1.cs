using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class scean1 : MonoBehaviour {
    public static float Score;
    public Text textScore;
	// Use this for initialization
	void Start () {
        textScore.text = Score.ToString();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
    public void startgame()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void EndGame()
    {
        Application.Quit();
    }
}
