using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Runner.LevelButton
{
    public class LevelButton : MonoBehaviour
    {
        public int sceneIndex;

        public void OpenScene()
        {
            SceneManager.LoadScene(sceneIndex);
        }

        public void ButtonClick()
        {
            SceneManager.LoadScene("menu");
        }
    }
}