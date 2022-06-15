using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomelessCrawlLogic : MonoBehaviour
{

    [SerializeField] private float _speed;
    [SerializeField] private AnnaInThePotAnimationController _inThePotAnimationController;


    private void OnEnable()
    {
        _inThePotAnimationController.OnHalfDanced += StartCrawl;
    }

    private void OnDisable()
    {
        _inThePotAnimationController.OnHalfDanced -= StartCrawl;
    }

    private void StartCrawl()
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
