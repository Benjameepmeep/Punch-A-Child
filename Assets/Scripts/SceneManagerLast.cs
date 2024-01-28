using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneManager : MonoBehaviour
{
    public void Loadlevel(string level)
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene(UnityEngine.SceneManagement.SceneManager.);

    }
    
    /*public void LoadSceneByName(string sceneName)
    {
        //Start a coroutine to wait until the fade is done
        StartCoroutine(LoadLevel(UnityEngine.SceneManagement.SceneManager.GetSceneByName(sceneName).buildIndex+1));
        return;
    }*/
    
    /*private IEnumerator LoadLevel(int levelIndex)
    {
        yield return new WaitForSeconds(0.01f);
        UnityEngine.SceneManagement.SceneManager.LoadScene(levelIndex);
    }*/
}
