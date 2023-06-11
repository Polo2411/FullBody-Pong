using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static UIManager Instance;
    public Text score1;
    public Text score2;
    public Text End1;
    public Text End2;
    public GameObject gameOverWindow1;
    public GameObject gameOverWindow2;
    public Image Powerup1;
    public Image Powerup2;
    public Sprite Slow;
    public Sprite Fast;
    public Sprite Pause;
    public Sprite Bigger;
    public Sprite Smaller;
    public Sprite x2Boost;
    public Sprite None;

    void Awake()
    {
        Instance = this;

    }

    public void Score1Update()
    {
        score1.text = GameManager.Instance.player1Score.ToString();
    }
    public void Score2Update()
    {
        score2.text = GameManager.Instance.player2Score.ToString();
    }
    public void PoweUpUpdate1(PowerUpType power)
    {
        switch (power)
        {
            case PowerUpType.Slow:
                Powerup1.sprite = Slow;
                break;
            case PowerUpType.Fast:
                Powerup1.sprite = Fast;
                break;
            case PowerUpType.Bigger:
                Powerup1.sprite = Bigger;
                break;
            case PowerUpType.Smaller:
                Powerup1.sprite = Smaller;
                break;
            case PowerUpType.Pause:
                Powerup1.sprite = Pause;
                break;
            case PowerUpType.x2Boost:
                Powerup1.sprite = x2Boost;
                break;
            case PowerUpType.None:
                Powerup1.sprite = None;
                break;
        }
    }

    public void PoweUpUpdate2(PowerUpType power)
    {
        switch (power)
        {
            case PowerUpType.Slow:
                Powerup2.sprite = Slow;
                break;
            case PowerUpType.Fast:
                Powerup2.sprite = Fast;
                break;
            case PowerUpType.Bigger:
                Powerup2.sprite = Bigger;
                break;
            case PowerUpType.Smaller:
                Powerup2.sprite = Smaller;
                break;
            case PowerUpType.Pause:
                Powerup2.sprite = Pause;
                break;
            case PowerUpType.x2Boost:
                Powerup2.sprite = x2Boost;
                break;
            case PowerUpType.None:
                Powerup2.sprite = None;
                break;
        }
    }

    public void Winner1()
    {
        End1.text = "WINNER";
        End2.text = "LOSER";
        gameOverWindow1.SetActive(true);
        gameOverWindow2.SetActive(true);
    }
    public void Winner2()
    {
        End1.text = "LOSER";
        End2.text = "WINNER";
        gameOverWindow1.SetActive(true);
        gameOverWindow2.SetActive(true);
    }
    public void Reset()
    {
        gameOverWindow1.SetActive(false);
        gameOverWindow2.SetActive(false);
    }
}
