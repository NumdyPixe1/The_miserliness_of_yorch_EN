using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class SpeechBubble : MonoBehaviour
{
    public GameObject speech;
    [SerializeField] private bool isSpeech;
    private void OnTriggerEnter2D(Collider2D other)//เมื่อเข้าใน BoxCollider2D
    {
        if (other.gameObject.tag == "Player")
        {
            speech.SetActive(true);//แสดงรูป
            isSpeech = true;
        }
    }

    private void OnTriggerExit2D(Collider2D other) //เมื่อออกจาก BoxCollider2D
    {
        if (other.gameObject.tag == "Player")
        {
            speech.SetActive(false);
            isSpeech = false;
        }
    }

    void Update()
    {
        if (Input.GetKey("f") && isSpeech == true)//เมื่อกด F และ isWarp เป็นจริง
        {
            Debug.Log("OK");
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);//เปลี่ยนฉาก
        }
    }
}
