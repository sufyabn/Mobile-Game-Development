using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Menu : MonoBehaviour
{ 
public void PlayGame()
    {
        SceneManager.LoadSceneAsync(1);
    }

}
