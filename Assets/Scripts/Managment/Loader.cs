using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loader : MonoBehaviour {

    public GameObject gameManager;
    //public GameObject uiManager;

    void Awake()
    {
        if (GameManager.instance == null)
        {
            gameManager = Instantiate(gameManager, this.transform);
            gameManager.name = "GameManager";
        }
    }
}
