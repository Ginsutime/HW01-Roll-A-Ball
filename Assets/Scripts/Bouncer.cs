using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bouncer : Enemy
{
    float force = 800;

    protected override void PlayerImpact(Player player)
    {
        player.DecreaseHealth(DamageAmount);

        var dir = transform.position - player.transform.position;

        dir = -dir.normalized;
        player.gameObject.GetComponent<Rigidbody>().AddForce(force * dir);
    }
}
