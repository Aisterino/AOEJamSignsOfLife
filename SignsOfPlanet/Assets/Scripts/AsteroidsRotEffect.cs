using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidsRotEffect : MonoBehaviour
{
    public float rotationSpeed;
    public float childRotSpeed;
    public float[] range = new float[2];
    public float childMoveSpeed;

    private void Update()
    {
        transform.Rotate(0, 0, rotationSpeed * Time.deltaTime);
        
        for(int i = 0; i < transform.childCount; i++)
        {
            Transform childTrans = transform.GetChild(i);

            childTrans.Rotate(0, 0, childRotSpeed * Time.deltaTime);

            /*

            Vector2 dir = childTrans.position - transform.position;
            Vector2 newPos = childTrans.position;
            newPos = dir.normalized * GetNewPos(childTrans);
            childTrans.position = newPos;

            */
        }
        
    }

    float GetNewPos(Transform childTrans)
    {
        float distance = Vector2.Distance(transform.position, childTrans.position);
        Vector2 dir = childTrans.position - transform.position;
        Vector2 newPos = childTrans.position;
        return Mathf.Clamp((Random.Range(range[0], range[1]) / 100 * childMoveSpeed), range[0] + distance, range[1] - distance);
    }
}
