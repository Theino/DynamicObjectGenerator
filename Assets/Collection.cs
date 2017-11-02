using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Collection : MonoBehaviour {

    public bool IsBad = false;

    public GameObject Player;
    public GameObject ScoreText;

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
                ScoreText.GetComponent<Text>().text += "+";
            }
        }
    }
}
