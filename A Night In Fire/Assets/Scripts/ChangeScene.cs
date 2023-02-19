using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ChangeScene : MonoBehaviour
{

    public void ChangeSceneFunction(int index)
    {
        SceneManager.LoadSceneAsync(index);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
