using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {

    public GameObject ThingToShoot;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("Fire1"))
        {
            Vector3 start = transform.position;
            start += transform.forward.normalized * 10;
            GameObject newObj = Instantiate<GameObject>(ThingToShoot, start, transform.rotation);
            newObj.GetComponent<Rigidbody>().velocity = transform.forward.normalized * 30;
        }
	}
}
