using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour
{
    public float Multiplier = 10f;
    public float MaxVelocity = 20f;
    private int score = 1;
    private Rigidbody componentPlayer;
    public TMPro.TextMeshPro scoreText;

    void Start()
    {
        componentPlayer = GetComponent<Rigidbody>();
    }

void Update()  
    {
        var horizontalForce = Input.GetAxis("Horizontal");
        var VerticalForce = Input.GetAxis("Vertical");

        if (componentPlayer.velocity.x <= MaxVelocity)
        {
            componentPlayer.AddForce(new Vector3(horizontalForce * Multiplier,0, VerticalForce * Multiplier));
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("enemy"))
        {
            Destroy(gameObject);
        }

        if (collision.gameObject.CompareTag("coin"))
        {
            scoreText.text = score.ToString();
            score += 1;
        }

    }

}



