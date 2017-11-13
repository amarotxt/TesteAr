using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControllerAudio : MonoBehaviour {

	public void Roar1(){
		FindObjectOfType<AudioManager> ().Play("Roar1");
	}

	public void Roar2(){
		FindObjectOfType<AudioManager> ().Play("Roar2");
	}

	public void Walking(){
		FindObjectOfType<AudioManager> ().Play("Walking");	
	}

	public void Swing1(){
		FindObjectOfType<AudioManager> ().Play("Swing1");	
	}

	public void Swing2(){
		FindObjectOfType<AudioManager> ().Play("Swing2");	
	}
}
