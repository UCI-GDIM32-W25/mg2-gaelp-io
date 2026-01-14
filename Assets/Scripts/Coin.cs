using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 3f;

    private void Update()
    {
        transform.Translate(Vector2.left * moveSpeed * Time.deltaTime);

        // Destroy coin if it goes too far left (off screen)
        if (transform.position.x < -12f)
        {
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            UIManager.Instance.AddPoint();
            Destroy(gameObject);
        }
    }
}
