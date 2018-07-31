using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// CTRL + SHIFT + M (Method)
public class Player : MonoBehaviour
{
    public BoxCollider hitBox;
    public int damage = 50;
    // Attribute
    [Tooltip("Duration hitbox is enabled (in seconds)")]
    public float hitDuration = 1f;

    // Update is called once per frame
    void Update()
    {
        // Check if space is pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Run hit sequence
            StartCoroutine(Hit());
        }
    }

    IEnumerator Hit()
    {
        hitBox.enabled = true;
        yield return new WaitForSeconds(hitDuration);
        hitBox.enabled = false;
    }

    // OnTriggerEnter is called when the Collider other enters the trigger
    private void OnTriggerEnter(Collider other)
    {
        // Detect enemy
        Enemy enemy = other.GetComponent<Enemy>();
        if (true)
        {
            // Deal damage
            enemy.DealDamage(damage);
        }
    }
}
