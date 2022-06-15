using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomelessCrawlLogic : MonoBehaviour
{

    [SerializeField] private float _speed;
    private void Start()
    {
        StartCoroutine(Crawl());
    }

    IEnumerator Crawl()
    {
        while (true)
        {
            transform.Translate(Vector3.forward * _speed);
            yield return null;
        }

    }
    
}
