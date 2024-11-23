using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ButtonManager : MonoBehaviour
{
    [SerializeField] private GameObject introText;

    private void Start()
    {
        Time.timeScale = 0f;
    }

    public void StartGame(GameObject startButton)
    {
        Time.timeScale = 1f;
        startButton.SetActive(false);
        introText.SetActive(false);
    }

    public void Restart(GameObject restartButton)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        restartButton.SetActive(false);
    }
}
