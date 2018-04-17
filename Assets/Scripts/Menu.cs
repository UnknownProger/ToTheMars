using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour {

    public void Play_Click()
    {
        SceneManager.LoadSceneAsync(1, LoadSceneMode.Single);
    }

    public void Settings_Click()
    {
        
    }

    public void DLC_Click()
    {
        
    }

    public void Creators_Click()
    {
        
    }



}
