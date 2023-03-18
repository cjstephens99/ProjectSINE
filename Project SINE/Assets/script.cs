using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class script : MonoBehaviour
{
    public Vector2 screenPosition;
    public Vector2 worldPosition;

    public LineRenderer myLineRenderer;
    public int points;
    public float amplitude = 0;
    public float frequency;
    public Vector2 xLimits = new Vector2(-10,10);

    // Start is called before the first frame update
    void Start()
    {
        myLineRenderer = GetComponent<LineRenderer>();
    }

    void Draw()
    {
        
        float xStart = xLimits.x;;
        float Tau = 2* Mathf.PI;
        float xFinish = xLimits.y;
        frequency = 1/(xFinish - xStart);

        myLineRenderer.positionCount = points;
        for(int currentPoint = 0; currentPoint<points;currentPoint++)
        {
            float progress = (float)currentPoint/(points-1);
            float x = Mathf.Lerp(xStart,xFinish,progress);
            float y = amplitude * Mathf.Sin(x * frequency * Tau);
            myLineRenderer.SetPosition(currentPoint, new Vector3(x,y,0));
        }

    }
/*
    float Lerp(float firstValue, float secondValue, float progress)
    {
        float difference = secondValue - firstValue;
        return firstValue + (difference * progress);
    }
*/
    // Update is called once per frame
    void Update()
    {

        if(Input.GetMouseButton(0)){
            //https://gamedevbeginner.com/how-to-convert-the-mouse-position-to-world-space-in-unity-2d-3d/#:~:text=In%20Unity%2C%20getting%20the%20mouse,Simple.

            screenPosition = Input.mousePosition;
            worldPosition = Camera.main.ScreenToWorldPoint(screenPosition);
            transform.position = worldPosition;

            //if mouse is on the left side of the screen...
            if(worldPosition.x < 0){
                amplitude = 1-worldPosition.y -1; 
            }
            //if the mouse is on the right side of the screen...
            else{
                amplitude = worldPosition.y; 
            }
            
        }
        else{//if the mouse isnt being pressed, gradually reset the amplitude of the wave
            
            if(amplitude != 0){
                amplitude /= (float)1.01;
            }
            
        }
        Draw();
    }
}
