using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collection : MonoBehaviour {

    public bool IsBad = false;

    public GameObject Player;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void HandleCollision(GameObject collidedObject)
    {
        if(collidedObject == Player)
        {
            if(IsBad)
            {

            }
        }
    }
}
