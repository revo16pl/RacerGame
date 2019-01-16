using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{
    public bool isActive = true;

    void Start()
    {
        
    }
    void Update()
    {
        transform.rotation = Quaternion.Euler(0, Time.timeSinceLevelLoad * 60f, -90);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.tag == "Player")
        {
            GetComponent<MeshRenderer>().enabled = false;
            GetComponent<AudioSource>().Play();
            isActive = false;
        }
    }
}
