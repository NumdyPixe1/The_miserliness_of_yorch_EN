using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public SceneChange sceneChange;
    [SerializeField] private TextMeshProUGUI textBlinking;//ตัวText
    [SerializeField] private GameObject startButton, optionButton, exitButton, optionPanel;

    Animator animator;
    void Start()
    {

    }

    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            Application.Quit();
        }

    }
    // void BlinkingText()
    // {
    //     StartCoroutine(StartBlinking());
    // }
    // IEnumerator StartBlinking()
    // {
    //     while (true)
    //     {
    //         textBlinking.text = "Press Any Button to Start";
    //         yield return new WaitForSeconds(1f);
    //         textBlinking.text = "";
    //         yield return new WaitForSeconds(1f);
    //         //textBlinking.text = "Press Any Button to Start";
    //     }
    // }

    public void OnClick_StartGame()
    {
        sceneChange.FadeToNextScene();
    }
    public void OnClick_Option()
    {
        optionPanel.SetActive(true);
        startButton.SetActive(false);
        optionButton.SetActive(false);
        exitButton.SetActive(false);

    }

    public void OnClick_Exit()
    {
        Application.Quit();
        print("Quit");
    }



























}
