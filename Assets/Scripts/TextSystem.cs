using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class TextSystem : MonoBehaviour
{
    public GameObject Button;
    [SerializeField] private TextMeshProUGUI myText;
    [SerializeField] private string[] Script;

    
    private int index;

    static bool RunOnce = false;

    int i = 0;

    private void Start()
    {
        myText.text = "...";
    }

    private void Update()
    {
        if(myText.text == Script[index])
        {
            Button.SetActive(true);
        }
    }

   

    IEnumerator TypeSentence()
    {
        myText.text = "";

        foreach( char letter in Script[index].ToCharArray())
        {
            myText.text += letter;
            yield return null;
        }
    }

    public void NextSentence()
    {
        Button.SetActive(false);

        if (index < Script.Length - 1)
        {
            index++;
            myText.text = "";
            StartCoroutine(TypeSentence());
        }
        else
        {
            myText.text = "";
        }
    }

    public void ButtonPress() // not in use
    {
        myText.text = Script[i];

        i++;

        if (i == Script.Length)
        {

            gameObject.transform.GetComponentInParent<Canvas>().enabled = false;
        }
        else
        {
            myText.text = Script[i];
        }

    }

    public void FirstTimeHub()// not in use
    {

        if (RunOnce == false)
        {
            myText.text = Script[i];

            i++;

            if (i == Script.Length)
            {
                gameObject.transform.GetComponentInParent<Canvas>().enabled = false;
                RunOnce = true;
            }
            else
            {
                myText.text = Script[i];
            }
        }
        else
        {
            gameObject.transform.GetComponentInParent<Canvas>().enabled = false;
        }

    }

}
