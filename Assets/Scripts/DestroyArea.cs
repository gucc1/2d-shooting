﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyArea : MonoBehaviour
{
    void OnTriggerExit2D(Collider2D c){
        Debug.Log("OnTriggerExit");
        Destroy(c.gameObject);
    }
}
