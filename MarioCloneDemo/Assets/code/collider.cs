using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;

public class collider : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        UnityEngine.Debug.Log("Enter");
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        UnityEngine.Debug.Log("Exit");
    }
    private void OnCollisionStay2D(Collision2D collision)
    {
        UnityEngine.Debug.Log("Stay");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        UnityEngine.Debug.Log("Enter");
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        UnityEngine.Debug.Log("Exit");
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        UnityEngine.Debug.Log("Stay");
    }
}
