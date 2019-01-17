using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class speeder : MonoBehaviour
{
    public GameObject player;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            var rigidbody = player.GetComponent<Rigidbody>();
            var movement = FindObjectOfType<movement>();

            rigidbody.AddForce((Vector3.right) * 2000f);
        }
    }
}
