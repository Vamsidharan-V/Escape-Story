using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartTextLv1 : MonoBehaviour
{
    public GameObject InitialText;

    // Start is called before the first frame update
    void Start()
    {
        InitialText.SetActive(false);
        
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
        InitialText.SetActive(true);
        yield return new WaitForSeconds(5);
        InitialText.SetActive(false);
    }
}
