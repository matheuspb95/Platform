using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerDie : MonoBehaviour {
    public Text Lifes;
    public Text GameOver;
    public int DinoLifes;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.CompareTag("Bullet"))
        {
            DinoLifes--;
            Lifes.text = "Lifes: " + DinoLifes;
            if(DinoLifes <= 0)
            {
                GameOver.text = "Game Over";
            }
        }
    }
}
