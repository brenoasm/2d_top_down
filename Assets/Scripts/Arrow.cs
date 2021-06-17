using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour {
    [HideInInspector] public float arrowVelocity;
    [HideInInspector] public float arrowDamage;
    [SerializeField] Rigidbody2D rb;

    private void Start() {
        Destroy(gameObject, 4f);
    }

    private void FixedUpdate() {
        rb.velocity = transform.up * arrowVelocity;    
    }

    private void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.tag == "Enemy") {
            Debug.Log("Enemy Attacked");

            Enemy enemy = other.gameObject.GetComponent<Enemy>();
            enemy.TakeDamage(arrowDamage);
        }

        Destroy(gameObject);
    }
}
