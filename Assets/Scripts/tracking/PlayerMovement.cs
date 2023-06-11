using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public GameManager game_manager;
    [SerializeField] int playerIndex;
    private float position;
    private float currentY = 30.0f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (currentY <= -13)
        {
            usePowerup(playerIndex);
        }

    }

    public void setPosition(Vector3 pos)
    {
        Vector3 newPos = new Vector3();
        if (playerIndex == 1)
        {
            newPos.x = Mathf.Clamp(pos.x, 10, 90);
            newPos.y = 0;
            newPos.z = Mathf.Clamp(pos.z, 5, 20);
        }
        else if (playerIndex == 2)
        {
            newPos.x = Mathf.Clamp(pos.x, 10, 90);
            newPos.y = 0;
            newPos.z = Mathf.Clamp(pos.z, 80, 95);
        }
        transform.position = newPos;

    }

    public void usePowerup(int player)
    {
        if (player == 1)
        {
            PowerUpType power = PowerUpType.None;
            power = game_manager.GetCurrentPowerup(1);
            if (power != PowerUpType.None) { SoundManager.Instance.PlayUsePowerSound(); }
            game_manager.usePowerup(power, 1);
            game_manager.Powerup1(PowerUpType.None);

        }
        else if (player == 2)
        {
            PowerUpType power = PowerUpType.None;
            power = game_manager.GetCurrentPowerup(2);
            if (power != PowerUpType.None) { SoundManager.Instance.PlayUsePowerSound(); }
            game_manager.usePowerup(power, 2);
            game_manager.Powerup2(PowerUpType.None);
        }
    }
}