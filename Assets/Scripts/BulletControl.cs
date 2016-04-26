using UnityEngine;
using System.Collections;

public class BulletControl : MonoBehaviour {

	private Rigidbody rb;
	private int weakDmg;
	private int strongDmg;
	private int superStrongDmg;

	public float bulletSpeed;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
		weakDmg = 10;
		strongDmg = 15;
		superStrongDmg = 25;
	}
	
	// Update is called once per frame
	void Update () {
		rb.AddForce (transform.forward * bulletSpeed);
	}

	void OnTriggerEnter (Collider collider) {
		if (collider.transform.tag == "enemy") {
			EnemyDamage enemyDmg;
			enemyDmg = collider.transform.GetComponent<EnemyDamage>();

			switch (enemyDmg.enemyType) {
				case EnemyDamage.Enemies.Weak:
					enemyDmg.doDamage(weakDmg);
					break;
				case EnemyDamage.Enemies.Strong:
					enemyDmg.doDamage(strongDmg);
					break;
				case EnemyDamage.Enemies.SuperStrong:
					enemyDmg.doDamage(superStrongDmg);
					break;
			}
			Destroy(gameObject);
		}
	}
}
