using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManeger : MonoBehaviour {
    public static float score = 0;
    // Use this for initialization
    Text textscore;
    void Start () {
		 textscore = GameObject.Find("Text").GetComponent<Text>();
         score = 0;
	}
	
	// Update is called once per frame
	void Update () {
        textscore.text = score.ToString();
    }

    public static void EndGame()
    {
        scean1.Score = score;
        SceneManager.LoadScene("GameOver");

    }
}
