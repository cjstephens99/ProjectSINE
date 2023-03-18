using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class drawIndicator : MonoBehaviour
{

    public float initialRadius = 1.0f;
    private int numSteps = 100;
    private float distance;
    private float initialDistance;
    private float newRadius;

    public LineRenderer circleRenderer;
    public GameObject notePreFab;

    // Start is called before the first frame update
    void Start()
    {
        drawCircle(numSteps, initialRadius);
        initialDistance = (transform.parent.position - notePreFab.transform.position).magnitude;
    }

    // Update is called once per frame
    void Update()
    {
        distance = (transform.parent.position - notePreFab.transform.position).magnitude;
        newRadius = distance/initialDistance;
        drawCircle(numSteps, newRadius);
    }

    void drawCircle(int steps, float radius)
    {
        circleRenderer.positionCount = steps;

        for (int currentStep = 0; currentStep < steps; currentStep++)
        {
            float circumferenceProgress = (float)currentStep / steps;

            float currentRadian = circumferenceProgress * 2 * Mathf.PI;

            float xScaled = Mathf.Cos(currentRadian);
            float yScaled = Mathf.Sin(currentRadian);

            float x = xScaled * radius;
            float y = yScaled * radius;

            Vector3 currentPosition = new Vector3(x,y,0);
            Vector3 drawPosition = transform.parent.position + currentPosition;

            circleRenderer.SetPosition(currentStep, drawPosition);
        }
    }

}
