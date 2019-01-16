using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    public Transform playerPosition;
    public Vector3 shift;
    public GameObject player;

    void FixedUpdate()
    {
        transform.LookAt(playerPosition);

        Rigidbody rigidbody = player.GetComponent<Rigidbody>();
        float speed = rigidbody.velocity.magnitude;
        
        var targetPosition = playerPosition.position + shift * ((speed / 30 + 1f));
        transform.position = Vector3.Lerp(transform.position, targetPosition, Time.deltaTime * 2f);

    }
}
