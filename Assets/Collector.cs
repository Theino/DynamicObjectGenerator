using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Assets;

public class Collector : MonoBehaviour {

    public GameObject Player;
    public GameObject ScoreText;

    private string startText;

    // Use this for initialization
    void Start () {
        Text TextComponent = ScoreText.GetComponent<Text>();
        startText = TextComponent.text;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnTriggerEnter(Collider collidedObject)
    {
        GameObject collidedGameObject = collidedObject.transform.gameObject;
        Debug.Log("collided");
        Collection collectionThatCollided = collidedGameObject.GetComponent<Collection>();
        if (collectionThatCollided != null)
        {
            if(collectionThatCollided.IsBad)
            {
                GlobalVariables.Score += -10;
            }
            else
            {
                GlobalVariables.Score += 1;
            }
            Text TextComponent = ScoreText.GetComponent<Text>();
            TextComponent.text = startText + GlobalVariables.Score.ToString();
            Destroy(collidedGameObject);

        }
    }
}
