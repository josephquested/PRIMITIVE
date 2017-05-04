﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomizeAudioPitch : MonoBehaviour {

	// SYSTEM //

	public float minPitch;
	public float maxPitch;

	void Start ()
	{
		AudioSource audioSource = GetComponent<AudioSource>();
		audioSource.pitch = Random.Range(minPitch, maxPitch);
	}
}
