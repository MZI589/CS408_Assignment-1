using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Modify : MonoBehaviour
{
    // Start is called before the first frame update
    private ParticleSystem ps;
    public KeyCode increaseAlpha;
    public KeyCode decreaseAlpha;
    public KeyCode increaseRed;
    public KeyCode increaseGreen;
    public KeyCode increaseBlue;
    public KeyCode decreaseRed;
    public KeyCode decreaseGreen;
    public KeyCode decreaseBlue;
    public KeyCode plusKey;
    public KeyCode minusKey;

    public float alphaLevel = 1.00f;
    public float redValue = 0.25f;
    public float greenValue = 0.25f;
    public float blueValue = 0.25f;
    public float speed = 5.00f;
    public float size = 10.00f;
    public float direction = -30.00f;
    void Start()
    {
        ps = GetComponent<ParticleSystem>();

    }

    // Update is called once per frame
    void Update()
    {
        var main = ps.main;
        var sh = ps.shape;
        if (Input.GetKeyDown(increaseAlpha))
        {
           if (alphaLevel <= .96f)
           {
              alphaLevel += .05f;
           }

        }
        if (Input.GetKeyDown(decreaseAlpha))
        {
           if (alphaLevel >= .04f)
            {
              alphaLevel -= .05f;
            }
        }
        if (Input.GetKeyDown(increaseRed))
        {
           if (redValue <= .96f)
           {
              redValue += .05f;
           }
        }
        if (Input.GetKeyDown(increaseGreen))
        {
           if (greenValue <= .96f)
           {
              greenValue += .05f;
           }
        }
        if (Input.GetKeyDown(increaseBlue))
        {
           if (blueValue <= .96f)
           {
              blueValue += .05f;
           }
        }
        if (Input.GetKeyDown(decreaseRed))
        {
           if (redValue >= .04f)
           {
              redValue -= .05f;
           }
        }
        if (Input.GetKeyDown(decreaseGreen))
        {
           if (greenValue >= .04f)
           {
              greenValue -= .05f;
           }
        }
        if (Input.GetKeyDown(decreaseBlue))
        {
           if (blueValue >= .04f)
           {
              blueValue -= .05f;
           }
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
           if (speed <= 9.00f)
           {
              speed += 1.00f;
           }
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
           if (speed >= 1.00f)
           {
              speed -= 1.00f;
           }
        }
        if (Input.GetKeyDown(plusKey))
        {
           if (size <= 195.00f)
           {
              size += 5.00f;
           }
        }
        if (Input.GetKeyDown(minusKey))
        {
           if (size >= 5.00f)
           {
              size -= 5.00f;
           }
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
              direction -= 5.00f;
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
              direction += 5.00f;
        }

        GetComponent<ParticleSystem> ().startColor = new Color (redValue,greenValue,blueValue,alphaLevel);
        main.simulationSpeed = speed;
        GetComponent<ParticleSystem> ().startSize = size;
        sh.rotation = new Vector3 (0, direction, 270);

    }
}
