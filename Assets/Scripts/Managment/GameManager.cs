using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum GAME_STATE {PLAY, PAUSE};

public class GameManager : MonoBehaviour {

	public static GameManager instance = null;
	public GAME_STATE state = GAME_STATE.PLAY;
	public int sceneNum = 0; // 0 - main menu, 1 - game scene

	void Awake()
	{
		if (instance == null) 
		{
			instance = this;
		} 
		else if (instance != this) 
		{
			Destroy (this.gameObject);
		}

		DontDestroyOnLoad (this.gameObject);

		InitGame();
	}


	void InitGame()
	{

	}
}
