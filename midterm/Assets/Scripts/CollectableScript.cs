using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CollectableScript : MonoBehaviour
{
    static int score;
    public TMP_Text scoreText;
    public GameObject HayStackObj;

    // Start is called before the first frame update
    void Start()
    {
        HayStackObj.SetActive(false);

    }

    // Update is called once per frame
    void Update()
    {

    }


    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            score++;
            SetScoreText();

            Destroy(this.gameObject);

        }

        if (score >= 16)
        {
            HayStackObj.SetActive(true);
            Instantiate(HayStackObj);
        }
    }

    void SetScoreText()
    {
        scoreText.text = "Brushes: " + score;
    }
}
