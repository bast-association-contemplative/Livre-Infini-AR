using UnityEngine;
using System.Collections;

public class movie : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		((MovieTexture)GetComponent<Renderer>().material.mainTexture).Play();
		((MovieTexture)GetComponent<Renderer>().material.mainTexture).loop = true;
		GetComponent<AudioSource>().Play ();
	}
	
	// Update is called once per frame
	void Update (){
	}
}
