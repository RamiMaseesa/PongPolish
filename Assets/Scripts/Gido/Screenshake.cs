using System.Collections;
using System.Collections.Generic;
using UnityEditor.UIElements;
using UnityEngine;

public class Screenshake : MonoBehaviour
{
    public IEnumerator Shake (float _duration, float _intensity)
    {
        Vector3 originalPos = transform.localPosition;

        float elapsed = 0.0f;
        while (elapsed < _duration)
        {
            float x = Random.Range(-1f, 1f) * _intensity;
            float y = Random.Range(-1f, 1f) * _intensity;

            transform.localPosition = new Vector3(x, y, originalPos.z);
            elapsed += Time.deltaTime;
            yield return null;
        }

       transform.localPosition = originalPos;
    }
   
    
}
