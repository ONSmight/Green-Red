using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour {

    public GameObject BulletBlue;
    public GameObject BulletRed;
    GameObject spawenedbullet;

    // Use this for initialization
    void Start () {
    }
	
	// Update is called once per frame
	void Update () {
        Shoot();
	}
    void Shoot()
    {
        if (Player.isfliped == false)
        {
            Vector3 temp = transform.position;
            if (Input.GetMouseButtonDown(0))
            {
                GameObject.Instantiate(BulletBlue, temp, Quaternion.identity);
            }
            else if (Input.GetMouseButtonDown(1))
            {
                GameObject.Instantiate(BulletRed, temp, Quaternion.identity);;
            }
        }
        else if (Player.isfliped == true)
        {
            Vector3 temp =transform.position;
            if (Input.GetMouseButtonDown(0))
            {
                spawenedbullet = GameObject.Instantiate(BulletBlue, temp, Quaternion.identity);
                spawenedbullet.transform.localScale = new Vector3(transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);
            }
            else if (Input.GetMouseButtonDown(1))
            {
                spawenedbullet = GameObject.Instantiate(BulletRed, temp, Quaternion.identity);
                spawenedbullet.transform.localScale = new Vector3(transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);
            }
        }

        
    }
}
