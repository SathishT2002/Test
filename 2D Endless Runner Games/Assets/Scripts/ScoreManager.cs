using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Runner.ScoreManager
{
    public class ScoreManager : MonoBehaviour
    {
        public Text scoreText;
        private float score;
        public Text HighScore;
        public Text Level;
        private float scoreToNextLevel;
        public GameObject Panel;
        
        void Start()
        {
            HighScore.text = PlayerPrefs.GetInt("HighValue", 0).ToString();
            Level.text = "1";
        }

        void Update()
        {
            if (GameObject.FindGameObjectWithTag("Player") != null)
            {
                score += 1 * Time.deltaTime;
                scoreText.text = ((int)score).ToString();
                int MyScore = (int)score;

                if (MyScore > PlayerPrefs.GetInt("HighValue", 0))
                {
                    PlayerPrefs.SetInt("HighValue", MyScore);
                    HighScore.text = MyScore.ToString();
                }
                if ((int)score == 5)
                {
                    Panel.SetActive(true);
                }
                if((int)score == 10)
                {
                    Panel.SetActive(true);
                }
                if((int)score == 15)
                {
                    Panel.SetActive(true);
                }
                /*scoreToNextLevel = 0;
                if (score > scoreToNextLevel)
                {
                    Level.text = 1.ToString();
                }*/   
            }   
        }
    }
}