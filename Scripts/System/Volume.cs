using System.Collections;
using UnityEngine;

public class Volume : MonoBehaviour {

		public void VolumeControl(float volumeControl) {
		AudioListener.volume = volumeControl; 
	}
}
