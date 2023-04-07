using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.Events;

public class CoinPlayer : MonoBehaviour
{
    public TextMeshProUGUI Coins_menu;
    public TextMeshProUGUI End ;
    public int coins = 0;
    public AudioClip coinCollectSound;
  
    // Start is called before the first frame update
    void Start()
    {
        End.text = "";
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Coin")
        {
            coins++;
            Destroy(other.gameObject);
            Coins_menu.text = "" + coins;
            AudioSource.PlayClipAtPoint(coinCollectSound, transform.position);
        }
        if (coins==10)
        {
            Coins_menu.enabled = false;
            End.text = "Вы выиграли";
            StartCoroutine(WaitForIt(5.0F));
            
        }
        if (other.gameObject.tag == "CoinRed")
        {
            Coins_menu.enabled = false;
           
            SceneManager.LoadScene("Playground");
        }

        IEnumerator WaitForIt(float waitTime)
        {
            yield return new WaitForSeconds(waitTime);
            SceneManager.LoadScene("Playground");
            
        }
       
    }
}
