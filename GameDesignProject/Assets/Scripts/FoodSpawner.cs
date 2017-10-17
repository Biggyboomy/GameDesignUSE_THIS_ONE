using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FoodSpawner : MonoBehaviour {

    public GameObject food;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Object"))
        {
            Destroy(other.gameObject);
            Instantiate( food, transform.position, transform.rotation);
            // Play good boy sound here
        }
    }
}
