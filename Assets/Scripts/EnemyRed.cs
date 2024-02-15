using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class EnemyRed : MonoBehaviour {

    public float speed = 2f;

    // Use this for initialization
    void Start () {
    }
	
	// Update is called once per frame
	void Update () {
        if (transform.localScale.x < 0)
        {
            Vector3 temp = transform.position;
            temp.x -= speed * Time.deltaTime;
            transform.position = temp;
        }
        if (transform.localScale.x > 0)
        {
            Vector3 temp = transform.position;
            temp.x += speed * Time.deltaTime;
            transform.position = temp;
        }
    }

    void OnTriggerEnter2D(Collider2D Target)
    {
        if (Target.tag == ("BulletRed"))
        {
            Destroy(gameObject);
            Destroy(Target.gameObject);
            GameManeger.score++;
        }
        else if (Target.tag == ("BulletGreen"))
        {
            GameManeger.EndGame();
        }
    }

    void OnCollisionEnter2D(Collision2D Target)
    {
        if (Target.gameObject.tag == ("Player"))
        {
            GameManeger.EndGame();
        }
    }

}
