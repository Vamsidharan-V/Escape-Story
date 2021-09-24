using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ontrigger : MonoBehaviour
{
    public GameObject Text;
    public AudioSource Aud;
    // Start is called before the first frame update
    void Start()
    {
        Text.SetActive(false);
        Aud.Stop();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Text.SetActive(true);
            Aud.Play();
        }
        StartCoroutine(enterp());
    }
    IEnumerator enterp()
    {
        yield return new WaitForSeconds(5);
        Text.SetActive(false);
        Aud.Stop();
    }
}
