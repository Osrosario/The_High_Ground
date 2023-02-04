using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//added to load scenes
using UnityEngine.SceneManagement;

public class SceneScript : MonoBehaviour
{
    public int SceneIndex;
    
    public void ButtonToChangeLevel()
    {
        //loads the scene written in the inspector
        SceneManager.LoadScene(SceneIndex);
    }
}
