using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rooms : MonoBehaviour
{
    public SceneChange sceneChange;
    [SerializeField] private bool isPrevScene;
    public AudioSource audioSource;

    void Start()
    {

        audioSource = GetComponent<AudioSource>();
        //DontDestroyOnLoad(audioSource);
    }
    private void OnTriggerEnter2D(Collider2D other)//เมื่อเข้าใน BoxCollider2D
    {
        if (other.gameObject.tag == "Player")
        {
            isPrevScene = true;
            sceneChange.FadeToRoomScene0();
        }
    }
    private void OnTriggerExit2D(Collider2D other) //เมื่อออกจาก BoxCollider2D
    {
        if (other.gameObject.tag == "Player")
        {
            isPrevScene = false;
        }
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isPrevScene == true)//เมื่อกด F และ isWarp เป็นจริง
        {

            sceneChange.FadeToRoomScene0();
            Debug.Log("PrevScene");
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);//เปลี่ยนฉาก
        }
    }
}
