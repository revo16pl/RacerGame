using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{
    public bool isActive = true;

    void Update()
    {
        transform.rotation = Quaternion.Euler(0, Time.timeSinceLevelLoad * 60f, -90);     
    }

    private void OnTriggerEnter(Collider other)
    {
        if(isActive == true && other.tag == "Player")
        {
            GetComponent<MeshRenderer>().enabled = false;
            GetComponent<AudioSource>().Play();
            isActive = false;

            FindObjectOfType<GameController>().CoinsCollection();
        }        
    }
}
