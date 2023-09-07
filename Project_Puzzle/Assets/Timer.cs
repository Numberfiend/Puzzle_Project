using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;
public class Timer : MonoBehaviour
{
    float currentTime;
    public float startingTime = 60f;
    public float scoreamount;
    public float keepcount1;

    [SerializeField] TextMeshProUGUI countdownText;
    // Start is called before the first frame update
    
    void Start()
    {
        currentTime = startingTime;
        keepcount1 = 0f;
        scoreamount = 0f;
 
    }

    // Update is called once per frame
    void Update()
    {
        if (currentTime >0  && keepcount1 ==0)
        {
            currentTime -= 1 * Time.deltaTime;
            countdownText.text = "Player 1 Timer: " + currentTime.ToString("0");
        }
        

        else if(currentTime <= 0 || keepcount1!=0)
        {
            Destroy(this.gameObject);
            
            currentTime = 0;
            countdownText.text = "Player 1 Timer: " + currentTime.ToString("0");
            //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
    //Code from https://youtu.be/WxRsNge6Zuk
   
        
    

    
}
