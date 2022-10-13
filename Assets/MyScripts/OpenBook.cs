using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenBook : MonoBehaviour {
    public void Open() {
        transform.rotation = Quaternion.Euler(0, 0, -165f);
    }
}
