using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InvincibilityPowerup : PowerUpBase
{
    [SerializeField] Material playerDefault;
    [SerializeField] Material playerInvincible;

    protected override void PowerUp(Player player)
    {
        player.GetComponent<Renderer>().material = playerInvincible;
        player.GetComponent<Player>().checkDisabled = 0;
        Debug.Log("Test!");
    }

    protected override void PowerDown(Player player)
    {
        player.GetComponent<Renderer>().material = playerDefault;
        player.GetComponent<Player>().checkDisabled = 1;
    }
}
