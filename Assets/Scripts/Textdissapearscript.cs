using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Textdissapearscript : MonoBehaviour
{
    public GameObject AppearText;
    // Start is called before the first frame update
    void Start()
    {
        AppearText.SetActive(false);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void DisappearText()
    {
        StartCoroutine(DisappearT());
    }
    IEnumerator DisappearT()
    {
        AppearText.SetActive(true);
        yield return new WaitForSeconds(10);
        AppearText.SetActive(false);
    }
}
