using UnityEngine;
using System.Collections;

public class ShootTarget : MonoBehaviour {
    public GameObject BulletPrefab;
    public Transform target;
    public float velocity;
	// Use this for initialization
	void Start () {
        float time = Random.Range(2, 8);
        StartCoroutine(Shoot(time));
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    IEnumerator Shoot(float time)
    {
        yield return new WaitForSeconds(time);
        Shoot();
        time = Random.Range(2, 8);
        StartCoroutine(Shoot(time));
    }

    public void Shoot()
    {
        GameObject bullet = (GameObject)Instantiate(BulletPrefab, transform.position, Quaternion.identity);
        bullet.SetActive(true);
        Vector2 direction = target.position - transform.position;
        bullet.GetComponent<Rigidbody2D>().velocity = direction.normalized * velocity;
    }
}
