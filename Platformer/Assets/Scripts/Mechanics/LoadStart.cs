using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadGame : MonoBehaviour
{
    // Attach this script to your button

    // Function to be called when the button is clicked
    public void LoadLevel1Async()
    {
        // Start the asynchronous scene loading coroutine
        StartCoroutine(LoadLevelAsync("Level1"));
    }

    // Coroutine for asynchronous scene loading
    private IEnumerator LoadLevelAsync(string levelName)
    {
        // Begin loading the scene asynchronously
        AsyncOperation asyncOperation = SceneManager.LoadSceneAsync(levelName);

        // Allow the scene to load in the background
        asyncOperation.allowSceneActivation = false;

        // Check if the loading is complete
        while (!asyncOperation.isDone)
        {
            // You can perform tasks while the scene is loading (e.g., update a loading bar)

            // Check if the loading is almost complete (90% or higher)
            if (asyncOperation.progress >= 0.9f)
            {
                // Enable scene activation
                asyncOperation.allowSceneActivation = true;
            }

            yield return null;
        }
    }
}
