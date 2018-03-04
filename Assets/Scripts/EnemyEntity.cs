using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyEntity : MonoBehaviour {

	[SerializeField] int health = 10;
	[SerializeField] GameObject deathFX;
	[SerializeField] Transform parentForFX;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnParticleCollision(GameObject other) {
		health--;
		print(health);
		if (health <= 0) {
			GameObject fx = Instantiate(deathFX, transform.position, Quaternion.identity);
			fx.transform.parent = parentForFX;
        	Destroy(gameObject);
		}
    }
}
