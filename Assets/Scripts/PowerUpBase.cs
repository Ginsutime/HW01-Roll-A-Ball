using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class PowerUpBase : MonoBehaviour
{
    [SerializeField] int powerupDuration = 5;

    protected abstract void PowerUp(Player player);
    protected abstract void PowerDown(Player player);

    private void OnTriggerEnter(Collider other)
    {
        Player player = other.gameObject.GetComponent<Player>();
        if (player != null)
        {
            StartCoroutine(powerUpTime(player));
        }
    }

    IEnumerator powerUpTime(Player player)
    {
        this.gameObject.GetComponent<MeshRenderer>().enabled = false;
        PowerUp(player);
        Debug.Log("Works");

        yield return new WaitForSeconds(powerupDuration);

        PowerDown(player);
        this.gameObject.SetActive(false);
        Debug.Log("Also works");
    }
}
