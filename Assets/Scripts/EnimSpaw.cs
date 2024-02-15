using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnimSpaw : MonoBehaviour {
    public GameObject[] Enimes;
    GameObject SpawenedEnemy;

	// Use this for initialization
	void Start () {
        StartCoroutine(spawn());
    }
	
	// Update is called once per frame
	void Update () {
    }
    IEnumerator spawn()
    {
        yield return new WaitForSecondsRealtime(Random.Range(1f, 4f));
        if (gameObject.name == "Rightspawner")
        {
            SpawenedEnemy = GameObject.Instantiate(Enimes[Random.Range(0, Enimes.Length)], transform.position, Quaternion.identity);
            SpawenedEnemy.transform.localScale = new Vector3(SpawenedEnemy.transform.localScale.x * -1, SpawenedEnemy.transform.localScale.y, transform.localScale.z);
        
        }
        else if(gameObject.name == "Leftspawner")
        {
            GameObject.Instantiate(Enimes[Random.Range(0, Enimes.Length)], transform.position, Quaternion.identity);
        }
        StartCoroutine(spawn());
    }
}
