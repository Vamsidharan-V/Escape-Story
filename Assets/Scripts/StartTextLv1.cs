using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class StartTextLv1 : MonoBehaviour
{
    public GameObject InitialText;
    public AudioSource InitAudio;

    // Start is called before the first frame update
    void Start()
    {
        InitialText.SetActive(false);
        InitAudio.Stop();
        
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(InitT());

    }
    public void InitText()
    {
      
    }
    IEnumerator InitT()
    {
        yield return new WaitForSeconds(5);
        InitAudio.Play();
        InitialText.SetActive(true);
        yield return new WaitForSeconds(5);
        InitAudio.Stop();
        InitialText.SetActive(false);
    }
}
