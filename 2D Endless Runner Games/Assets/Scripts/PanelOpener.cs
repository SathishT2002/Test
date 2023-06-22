using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Runner.PanelOpener
{
    public class PanelOpener : MonoBehaviour
    {
        [SerializeField] public GameObject settingPanel;
        [SerializeField] public GameObject panel;
        [SerializeField] public AudioSource music;
        [SerializeField] public GameObject levelPanel;
        [SerializeField] public GameObject panel2;
        [SerializeField] public GameObject MainPanel;
        [SerializeField] public GameObject BackButton;


        private void Start()
        {
            settingPanel.SetActive(false);
        }

        public void OnButtonClick()
        {
            settingPanel.SetActive(false);
        }

        public void OpenPanel()
        {
            panel.SetActive(true);
        }

        public void Onmusic()
        {
            music.Play();
        }

        public void Offmusic()
        {
            music.Stop();
        }

        public void Reseat()
        {
            PlayerPrefs.DeleteAll();
        }

        public void LevelMap()
        {
            levelPanel.SetActive(true);
            MainPanel.SetActive(false);
            BackButton.SetActive(true);
        }

        public void NextPanelButton()
        {
            panel2.SetActive(true);
            levelPanel.SetActive(false);
            BackButton.SetActive(true);
        }

        public void Back()
        {
            panel2.SetActive(false);
            levelPanel.SetActive(false);
            BackButton.SetActive(false);
            MainPanel.SetActive(true);
        }

        public void PreviousPanelButton()
        {
            panel2.SetActive(false);
            levelPanel.SetActive(true);
            BackButton.SetActive(true);
        }
    }
}