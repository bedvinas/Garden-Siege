using UnityEngine;
using System.Collections;

public class SetStartVolume : MonoBehaviour {

    private MusicManager musicManager;

	// Use this for initialization
	void Start () {
        musicManager = GetComponent<MusicManager>();
        if (musicManager)
        {
            float volume = PlayerPrefsManager.GetMasterVolume();
            musicManager.ChangeVolume(volume);
        }
        else {
            Debug.LogWarning("Music manager not found in start scene, can't set volume");
        }
        
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
