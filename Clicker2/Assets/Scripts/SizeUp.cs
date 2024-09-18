using System.Collections;
using UnityEditor;
using UnityEngine;
using UnityEngine.EventSystems;

public class SizeUp : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    Coroutine coru;
    [SerializeField] float speed = 1f;
    [SerializeField] float time = 1f;
    float t = 0;

    [SerializeField] AnimationCurve curve;

    public void OnPointerDown(PointerEventData eventData)
    {
        if(coru != null)
        {
            StopCoroutine(coru);
        }

        coru = StartCoroutine(OnDown());
        //transform.localScale = Vector3.one * 2;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        if (coru != null)
        {
            StopCoroutine(coru);
        };
        coru = StartCoroutine(OnUp());
        //transform.localScale = Vector3.one;
    }

    IEnumerator OnDown()
    {
        Vector3 size = Vector3.zero;

        while (t < 1)
        {
            t += Time.deltaTime / time;

            size.x = xCurve.Evaluate(t);
            size.y = yCurve.Evaluate(t);

            transform.localScale = Vector3.one + size;
            yield return null;
        }
        t = 1;
        size.x = xCurve.Evaluate(t);
        size.y = yCurve.Evaluate(t);
        transform.localScale = Vector3.one + size;
    }

    IEnumerator OnUp()
    {
        Vector3 size = Vector3.zero;

        while (t > 0)
        {
            t += Time.deltaTime / time;

            size.x = xCurve.Evaluate(t);
            size.y = yCurve.Evaluate(t);

            transform.localScale = Vector3.one + size;
            yield return null;
        }
        t = 0;
        size.x = xCurve.Evaluate(t);
        size.y = yCurve.Evaluate(t);
        transform.localScale = Vector3.one + size;
    }

}
