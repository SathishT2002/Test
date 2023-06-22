using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Runner.GameOver
{
    public class GameOver : MonoBehaviour
    {
        public GameObject gameOverPanel;
        public GameObject menu;
        public GameObject mainmenu;
        

        // Update is called once per frame
        void Update()
        {
            if (GameObject.FindGameObjectWithTag("Player") == null)
            {
                gameOverPanel.SetActive(true);
            }
        }

        public void Restart()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
        public void MenuScren()
        {
            SceneManager.LoadScene("menu");
        }

        public void MainMenuScren()
        {
            SceneManager.LoadScene("mainmenu");
        }
       
    }
}