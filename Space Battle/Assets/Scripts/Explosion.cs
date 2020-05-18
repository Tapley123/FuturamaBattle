using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    [SerializeField] private float deleteExplosionTime = 4f;
    void Start()
    {
        StartCoroutine(DeleteExplosionCoroutine(deleteExplosionTime));
    }

    IEnumerator DeleteExplosionCoroutine(float time)
    {
        yield return new WaitForSeconds(time);
        Destroy(this.gameObject);
    }
}
