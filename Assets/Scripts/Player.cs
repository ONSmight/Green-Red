using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {

    public static bool isfliped;

	// Use this for initialization
	void Start () {
        isfliped = false;
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKey(KeyCode.LeftArrow))
        {
            transform.localScale = new Vector3(-1, 1, 1);
            isfliped = true;
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.localScale = new Vector3(1, 1, 1);
            isfliped = false;
        }
    }

}
