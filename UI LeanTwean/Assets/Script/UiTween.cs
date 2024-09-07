using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UiTween : MonoBehaviour {
    [SerializeField]
    private GameObject colorWheel, levelSuccess, backPanel, starLeft, starMiddle, starRight;

    private void Awake()
    {
        levelSuccess.transform.localScale = new Vector3(0, 0, 0);
        starLeft.transform.localScale = new Vector3(0, 0, 0);
        starMiddle.transform.localScale = new Vector3(0, 0, 0);
        starRight.transform.localScale = new Vector3(0, 0, 0);
    }

    private void Start()
    {
        LeanTween.rotateAround(colorWheel, Vector3.forward, -360f, 10f).setLoopClamp();
        LeanTween.scale(levelSuccess, new Vector3(1.5f, 1.5f, 1.5f), 2f).setDelay(0.5f)
            .setEase(LeanTweenType.easeOutElastic).setOnComplete(showLevelSuccessOnComplete);
        LeanTween.moveLocal(levelSuccess, new Vector3(0f, 650f, 0f), 0.7f).setDelay(2f)
            .setEase(LeanTweenType.easeInCubic);
        LeanTween.scale(levelSuccess, new Vector3(1, 1, 1), 2f).setDelay(1.7f).setEase(LeanTweenType.easeInCubic);
    }

    private void showLevelSuccessOnComplete()
    {
        LeanTween.moveLocal(backPanel, new Vector3(0f, 0f, 0f), 0.7f).setDelay(.5f).setEase(LeanTweenType.easeOutCirc)
            .setOnComplete(StarsAnim);
    }

    private void StarsAnim()
    {
        LeanTween.scale(starLeft, new Vector3(1f, 1f, 1f), 2f).setEase(LeanTweenType.easeOutElastic);
        LeanTween.scale(starMiddle, new Vector3(1f, 1f, 1f), 2f).setDelay(.1f).setEase(LeanTweenType.easeOutElastic);
        LeanTween.scale(starRight, new Vector3(1f, 1f, 1f), 2f).setDelay(.2f).setEase(LeanTweenType.easeOutElastic);
    }
}