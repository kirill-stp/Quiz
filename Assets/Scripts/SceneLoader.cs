using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[CreateAssetMenu]
public class SceneLoader : ScriptableObject
{
    public void LoadStartScene()
    {
        SceneManager.LoadScene("StartScene");
    }

    public void LoadQuizScene()
    {
        SceneManager.LoadScene("QuizScene");
    }

    public void LoadEndScene()
    {
        SceneManager.LoadScene("EndScene");
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
