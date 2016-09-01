using UnityEngine;
using System.Collections;

public class SpawnEnemies : MonoBehaviour {
    public int numEnemies;
	public float respawnTime, YMinposition, YMaxposition, XminPosition, XmaxPosition;
    public GameObject EnemyPrefab;
	// Use this for initialization
	void Start () {
        StartCoroutine(Spawn());
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    IEnumerator Spawn()
    {
        while (true)
        {
            yield return new WaitForSeconds(respawnTime);
            for(int i = 0; i< numEnemies; i++)
            {
                GameObject newEnemy = (GameObject)Instantiate(EnemyPrefab);
                newEnemy.SetActive(true);
				newEnemy.transform.position = new Vector3(Random.Range(XminPosition, XmaxPosition), Random.Range(YMinposition, YMaxposition), 0);
            }
        }
    }
}
