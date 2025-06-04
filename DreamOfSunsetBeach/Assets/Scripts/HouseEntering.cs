using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HouseEntering : MonoBehaviour
{
    private GameObject textBox;
    [SerializeField] private GameObject textBoxText;
    private GameObject interaction;

    private bool inTrigger = false;
    private GameObject activeObject;

    private void Awake()
    {
        textBox = GameObject.Find("TextBox");
        interaction = GameObject.Find("InteractionText");
        textBoxText = textBox.GetComponentInChildren<TMP_Text>().gameObject;
    }

    private void Start()
    {
        textBox.SetActive(false);
        interaction.SetActive(false);
    }

    private void Update()
    {
        if (inTrigger == true && Input.GetKeyDown(KeyCode.Space))
        {
            textBox.SetActive(true);
            interaction.SetActive(false);
            Debug.Log("Spaced");

            if (activeObject.tag == "Police")
            {
                textBoxText.GetComponent<TMP_Text>().text = "Hellololol";
            }

            else
            {
                textBox.SetActive(false);
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        interaction.SetActive(true);
        inTrigger = true;
        activeObject = collision.gameObject;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        interaction.SetActive(false);
        inTrigger = false;
        textBox.SetActive(false);
    }
}
