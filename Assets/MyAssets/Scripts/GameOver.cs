using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{

    [SerializeField] GameObject buttonTryAgain;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "RedBlock" || other.gameObject.tag == "Ground")
        {
            GameOverMethod();
            
        }
    }

    private void GameOverMethod()
    {
        BoxColiderDisable();
        MoveForward speedMove = FindObjectOfType<MoveForward>();
        speedMove.SetZeroSpeedMove();
        buttonTryAgain.SetActive(true);
        print("Game over");
    }

    private void BoxColiderDisable()
    {
        Collider col = GetComponent<Collider>();
        col.GetComponent<Collider>();
        col.enabled = false;
    }

    public void tryAgainButtonClick()
    {
        SceneManager.LoadScene(0);

    }
}
