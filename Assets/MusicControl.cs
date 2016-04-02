using UnityEngine;
using System.Collections;
using FMODUnity;
public class MusicControl : MonoBehaviour {
	
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Q)){
			FMODUnity.RuntimeManager.PlayOneShot("event:/Music/HellCat");


		}
		if(Input.GetKeyDown(KeyCode.W)){
			FMODUnity.RuntimeManager.PlayOneShot("event:/Music/Music");
				
		}
		if(Input.GetKeyDown(KeyCode.E)){
			FMODUnity.RuntimeManager.PlayOneShot("event:/Ambience/Country");


		}
		if(Input.GetKeyDown(KeyCode.R)){
			FMODUnity.RuntimeManager.PlayOneShot("event:/Explosions/Single Explosion");

		}
	}
}
