using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour {

    public GameObject[] ThingsToShoot;

    private System.Random rand;
    // Use this for initialization
    void Start () {
        rand = new System.Random();
    }
	
	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("Fire1"))
        {
            int randNum = rand.Next(0, ThingsToShoot.Length);
            Vector3 start = transform.position;
            start += transform.forward.normalized * 5;
            GameObject newObj = Instantiate<GameObject>(ThingsToShoot[randNum], start, transform.rotation);
            newObj.GetComponent<Rigidbody>().velocity = transform.forward.normalized * 30;

            Transform gun = transform.Find("gun");
            Animation gunAnimation = gun.GetComponent<Animation>();
            gunAnimation.Stop();
            gunAnimation.Play();
        }
	}
}
