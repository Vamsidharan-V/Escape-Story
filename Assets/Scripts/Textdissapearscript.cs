using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Textdissapearscript : MonoBehaviour
{
    public GameObject AppearText;
    // Start is called before the first frame update
    void Start()
    {
       
        
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
        yield return new WaitForSeconds(3);
        AppearText.SetActive(false);
    }
}
