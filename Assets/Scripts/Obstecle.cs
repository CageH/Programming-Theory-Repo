using System.Collections;
using System.Collections.Generic;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Obstecle : MonoBehaviour
{
    //Encapsulation - choose your data
    private float m_Speed = 0.5f;//i dont now why, but its work only with static
    public float Speed
    {
        get { return m_Speed; }
        set
        {
            if (value < 0.0f)
            {
                Debug.LogError("You can't set a negative speed!");
            }
            else
            {
                m_Speed = value; 
            }
        }
    }
    //Abstraction - choose your functions
    public virtual void Move()
    {
        transform.Rotate(Vector3.back);
    }
    public void checkSpeed()
    {
        Debug.Log($"Corrent speed: {m_Speed}");
    }
    private void Update()
    {
    }
}
