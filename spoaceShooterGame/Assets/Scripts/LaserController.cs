using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserController : MonoBehaviour
{
    private Vector3 endTranslationPosition;
    private float speed = 50f;
    private float timeToDestroy = 15f;
    void Start()
    {
        Destroy(gameObject, timeToDestroy);
    }
    void Update()
    {
        transform.Translate(speed * Time.deltaTime * Vector3.up);
    }

    private IEnumerator TranslateOverTime(Transform objToTranslate, Vector3 endPosition, float speed)
    {
        if (objToTranslate != null)
        {
            float t = 0.0f;
            Vector3 startPosition = objToTranslate.position;
            while (t < 1.0f)
            {
                t += Time.deltaTime * speed;
                if (objToTranslate != null)
                {
                    objToTranslate.position = Vector3.Lerp(startPosition, endPosition, t);
                    yield return null;
                }
            }
            if (objToTranslate != null)
            {
                objToTranslate.position = endPosition;
            }
        }
    }
}