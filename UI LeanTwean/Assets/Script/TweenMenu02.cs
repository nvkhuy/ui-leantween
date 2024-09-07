using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TweenMenu02 : MonoBehaviour {
    [SerializeField]
    private GameObject next01, rotate01, heart01;

    private void Awake()
    {
    }

    private void Start()
    {
        DoExample01();
        DoExample02();
        DoExample03();
    }

    public void DoExample01()
    {
        next01.transform.localScale = new Vector3(0, 0, 0);
        next01.transform.localPosition = new Vector3(-900, 0, 0);
        LeanTween.scale(next01, new Vector3(1f, 1f, 1f), 0.5f).setEase(LeanTweenType.easeInOutQuad)
            .setLoopPingPong()
            .setFrom(new Vector3(0.5f, 0.5f, 0.5f));
        LeanTween.moveLocal(next01, new Vector3(0, 0, 0), 1).setDelay(1);
    }

    public void DoExample02()
    {
        rotate01.transform.localPosition = new Vector3(-900, 0, 0);
        LeanTween.rotateAround(rotate01, Vector3.forward, -360f, 1f).setLoopClamp();
        LeanTween.moveLocal(rotate01, new Vector3(0, 0, 0), 1).setDelay(1);
    }

    public void DoExample03()
    {
        LeanTween.alpha(heart01.GetComponent<RectTransform>(), 1f, 0.5f)
            .setFrom(0.2f) // Start fading from alpha 0.2
            .setEase(LeanTweenType.easeInOutQuad) // Smooth fade in and out
            .setLoopPingPong();
    }
}