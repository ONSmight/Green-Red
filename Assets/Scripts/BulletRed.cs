using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletRed : MonoBehaviour {

    public float speed;

	// Use this for initialization
	void Start () {
        Destroy(gameObject, 8f);
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 temp = transform.position;
       if(transform.localScale.x<0)
        {
            temp.x -= speed * Time.deltaTime;
            transform.position = temp;
        }
        else if (transform.localScale.x > 0)
        {
            temp.x += speed * Time.deltaTime;
            transform.position = temp;
        }

    }
}
