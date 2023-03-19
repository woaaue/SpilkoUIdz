using System.Collections;
using UnityEngine;

public class Clicakble : MonoBehaviour
{
    [SerializeField] private AnimationCurve _scaleCurve;

    public void Hit()
    {
        StartCoroutine(HitAnimation());
    }

    private IEnumerator HitAnimation()
    {
        for (float i = 0; i < 1f; i += Time.deltaTime / 0.25f)
        {
            float scale = _scaleCurve.Evaluate(i);
            transform.localScale = Vector3.one * scale;

            yield return null;
        }

        transform.localScale = Vector3.one;
    }
}
