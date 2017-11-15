using UnityEngine.Audio;
using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using Vuforia;

public class AudioManager : MonoBehaviour {

	public Sound[] sounds;

	// Use this for initialization
	void Start () {
		foreach(Sound sound in sounds){
			sound.source = gameObject.AddComponent<AudioSource> ();
			sound.source.clip = sound.clip;
			sound.source.volume = sound.volume;
			sound.source.playOnAwake = false;
			sound.source.pitch = sound.pitch;
			Debug.Log (sound.source.isPlaying);
		}
	}

	void Update(){
		StateManager sm = TrackerManager.Instance.GetStateManager ();

		// Query the StateManager to retrieve the list of
		// currently 'active' trackables 
		//(i.e. the ones currently being tracked by Vuforia)

		IEnumerable<TrackableBehaviour> activeTrackables = sm.GetActiveTrackableBehaviours ();

		// Iterate through the list of active trackables
		Debug.Log ("List of trackables currently active (tracked): ");
		Debug.Log (activeTrackables.GetType() + "-----");
		foreach (TrackableBehaviour tb in activeTrackables) {
			Debug.Log("Trackable: " + tb.TrackableName);
			if (tb.TrackableName.Equals ("dino")) {
				Debug.Log ("unmute");
				unmuteDino ();
				return;
			}
		}
		Debug.Log ("mute");
		muteDino ();
	
	}

	void muteDino(){
		foreach (Sound sound in sounds) {
			sound.source.volume = 0;
		}
	}

	void unmuteDino(){
		foreach (Sound sound in sounds) {
			sound.source.volume = 1;
		}
	}
	
	public void Play (string name){
		Sound s = Array.Find (sounds, sound => sound.name == name);
		s.source.Play ();
	}
}
