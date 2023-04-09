using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using Ink.Runtime;
public class DialogSystem : MonoBehaviour
{
    bool talker;
    public bool isStopTalking, isNextSentence;
    public TextMeshProUGUI textDisplay;
    public TextMeshProUGUI textName;
    public string[] sentences;
    public string[] chaName;//เพิ่มเติม
    // public GameObject[] chaImage;
    // public GameObject chaImage1;
    [SerializeField] public int index;
    [SerializeField] public float typingSpeed = 0.08f;
    public GameObject continueButton, continueArrow, dialogBox, dialogNameCha;

    [Header("Audio")]
    [SerializeField] private bool stopAudioSource;
    public AudioClip dialogTypingSoundCilp;
    AudioSource audioSource;

    void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        // audioSource = this.gameObject.AddComponent<AudioSource>();
        //audioSource.volume 
    }
    public void StartDialog()
    {
        StartCoroutine(TypeText());
        //chaImage1.SetActive(true);

    }
    void Start()
    {
        //StartCoroutine(TypeText());
        dialogNameCha.SetActive(false);
        dialogBox.SetActive(false);
        // chaImage1.SetActive(false);
    }

    public void NextSentence()//คลิกเพื่อเปลี่ยนบทสนทนา
    {
        Debug.Log("NextSentence");
        continueArrow.SetActive(false);
        continueButton.SetActive(false);
        if (index < sentences.Length - 1)
        {
            stopAudioSource = false;
            index++;
            textDisplay.text = "";
            StartCoroutine(TypeText());
        }
        else
        {
            isNextSentence = false;
            Debug.Log("Stop Talking");//เสร็จสิ้นการพูด
            isStopTalking = true;
            stopAudioSource = true;
            dialogBox.SetActive(false);
            dialogNameCha.SetActive(false);
            textDisplay.text = "";
        }
    }
    void Update()
    {
        // chaImage1 = chaImage[index];//เพิ่มเติม
        textName.text = chaName[index];//เพิ่มเติม
        if (stopAudioSource)
        {
            audioSource.Stop();
        }

        if (textDisplay.text == sentences[index])
        {
            isNextSentence = true;
            stopAudioSource = true;
            continueButton.SetActive(true);
            continueArrow.SetActive(true);
        }
        else
        {
            // chaImage1.SetActive(false);
            isNextSentence = false;
            stopAudioSource = false;
            continueButton.SetActive(false);
            continueArrow.SetActive(false);
        }

        if (Input.GetKeyDown(KeyCode.Space) && isNextSentence == true)
        {
            NextSentence();
        }


    }
    IEnumerator TypeText()
    {
        dialogNameCha.SetActive(true);
        dialogBox.SetActive(true);

        if (!stopAudioSource)
        {
            audioSource.PlayOneShot(dialogTypingSoundCilp);
        }

        foreach (char letter in sentences[index].ToCharArray())
        {
            textDisplay.text += letter;
            yield return new WaitForSeconds(typingSpeed);
            {

            }
        }
    }
}
