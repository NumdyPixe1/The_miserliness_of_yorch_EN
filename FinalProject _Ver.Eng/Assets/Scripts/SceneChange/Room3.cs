using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Room3 : MonoBehaviour
{
    public SceneChange sceneChange;
    [SerializeField] private bool isNextScene;
    public AudioSource audioSource;

    void Start()
    {

        audioSource = GetComponent<AudioSource>();
        // DontDestroyOnLoad(audioSource);
    }
    private void OnTriggerEnter2D(Collider2D other)//เมื่อเข้าใน BoxCollider2D
    {
        if (other.gameObject.tag == "Player")
        {
            isNextScene = true;
            //sceneChange.FadeToNextScene();

        }
    }
    private void OnTriggerExit2D(Collider2D other) //เมื่อออกจาก BoxCollider2D
    {
        if (other.gameObject.tag == "Player")
        {
            isNextScene = false;
        }
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isNextScene == true)
        {
            audioSource.Play();
            sceneChange.FadeToRoomScene3();
            Debug.Log("Room3");
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);//เปลี่ยนฉาก
        }
    }
    public void OnMouseDown()
    {
        // if ()
        // {
        audioSource.Play();

        // }
        sceneChange.FadeToRoomScene3();
        Debug.Log("Room1");
    }
}
