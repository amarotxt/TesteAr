using UnityEngine.Audio;
using UnityEngine;
using System;

public class AudioManager : MonoBehaviour {

	public Sound[] sounds;
	// Use this for initialization
	void Aweke () {
//		foreach(Sound sound in sounds){
//			sound.source = gameObject.AddComponent<AudioSource> ();
//			sound.source.clip = sound.clip;
//			sound.source.volume = sound.volume;
//			sound.source.pitch = sound.pitch;
//		}
	}
	
	public void Play (string name){
		Sound s = Array.Find (sounds, sound => sound.name == name);
//		s.source.Play ();
	}
}
