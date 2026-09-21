using System.Collections;
using System.Collections.Generic;
using UnityEditor.Build.Content;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PracticeSwitcher : MonoBehaviour
{
    private const string SCENE_A = "StaticPracticeA";
    private const string SCENE_B = "StaticPracticeB";


    private void Update()
    {
        ReadSceneKey();
    }
    private void ReadSceneKey()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            MoveToOtherScene();
        }
    }

    private void MoveToOtherScene()
    {
        string CurrentSecne = SceneManager.GetActiveScene().name;

        if(CurrentSecne == SCENE_A)
        {
            SceneManager.LoadScene(SCENE_B);
        }
        else
        {
            SceneManager.LoadScene(SCENE_A);
        }
    }

}
