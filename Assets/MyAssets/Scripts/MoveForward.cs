using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MoveForward : MonoBehaviour
{
    float speedMove = 0;
// [SerializeField] ParticleSystem Warp;
   // [SerializeField] ParticleSystem Slash ;


  //  [SerializeField] Text Score;
  //  [SerializeField] GameObject ScoreG;

  //  [SerializeField] Text CountCube;
  //  [SerializeField] GameObject CountCubeG;

    [SerializeField] GameObject playBtn;
   //[SerializeField] GameObject closeBtn;
    float scoreTemp = 0;

    private void Start()
    {
        
        
    }
  
   public void ReloadScene()
    {
        SceneManager.LoadScene(0);
    }
    
    private void Update()
    {
        touchBlock touchBlock = FindObjectOfType<touchBlock>();
        transform.Translate(0, 0, speedMove*Time.deltaTime);
        scoreTemp = scoreTemp + speedMove;
       // Score.text =(scoreTemp).ToString();
        //CountCube.text = (touchBlock.CountCube()).ToString();

    }

    public float GetSpeedMove()
    {
        return speedMove;
    }

    
    public void SetZeroSpeedMove()
    {
        
        //Warp.Stop();
        this.speedMove = 0;
       // Slash.Stop();
    }
    public void ButtonClickToPlay()
    {
        //Slash.Play();
       // Warp.Play();
        speedMove = 5f;
        playBtn.SetActive(false);
       // ScoreG.SetActive(true);
        //closeBtn.SetActive(true);
       // CountCubeG.SetActive(true);
    }

    public void CloseTable()
    {
        Debug.LogWarning("CloseTable");
        Application.Quit();
    }
}
