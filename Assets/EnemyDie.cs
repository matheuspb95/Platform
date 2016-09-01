using UnityEngine;
using System.Collections;

public class EnemyDie : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnCollisionEnter2D(Collision2D coll)
    {
        if (coll.gameObject.CompareTag("Player"))
        {
            coll.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * 500);
            Destroy(transform.parent.gameObject);
        }
    }
}
