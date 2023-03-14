using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public Transform gameOverPanel;
    public List<Transform> items;
    public Text scoreTxt;
    public int score;
    AudioSource audioSrc;

    void Start()
    {
        audioSrc = GetComponent<AudioSource>();
        gameOverPanel.gameObject.SetActive(false);
        scoreTxt.text = "" + 0;
        score= 0;
        for(int i=0; i<items.Count; i++)
        {
            items[i].gameObject.SetActive(true);
            items[i].GetComponent<Item>().manager = this;
        }
    }

    public int AddScore()
    {
        audioSrc.Play();
        score++;
        scoreTxt.text = "Score: " + score;
        //Debug.Log("Puntuacion: " + score);
        if(score == items.Count)//si la puntuacion es igual al tamaño de la lista
        {
            gameOverPanel.gameObject.SetActive(true);
        }
        return score;
    }

    public void LoadScene()
    {
        SceneManager.LoadScene("UFOScene");
    }
}
