using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Runner.PauseMenu
{
    public class PauseMenu : MonoBehaviour
    {
        [SerializeField] public GameObject pauseMenu;
        [SerializeField] public GameObject resumeMenu;
        [SerializeField] public GameObject homeMenu;
        
        public void Pause()
        {
            pauseMenu.SetActive(true);
            Time.timeScale = 0f;
        }

        public void Resume()
        {
            pauseMenu.SetActive(false);
            Time.timeScale = 1f;
        }

        public void Exit()
        {
            Application.Quit();
        }

        /*public void play()
        {
            SceneManager.LoadScene("menu");
        }*/

        public void Home()
        {
            SceneManager.LoadScene("mainmenu");
        }
    }
}