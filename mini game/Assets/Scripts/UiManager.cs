using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class UIManager : MonoBehaviour
{
    public TextMeshProUGUI coinAmountText;

    private int _coinAmount = 0;

    public Button replayButton;


    // Start is called before the first frame update
    void Start()
    {
        replayButton.gameObject.SetActive(false);
        coinAmountText.text = "Coins: 0" + _coinAmount.ToString() ;
    }


    public void UpdateCoinCount()
    {
        _coinAmount++;
        coinAmountText.text = "Coins: " + _coinAmount.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void GameOver()
    {
        replayButton.gameObject.SetActive(true);
    }

   public void ReplayGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
