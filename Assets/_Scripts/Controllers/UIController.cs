using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    [field:SerializeField] public Button Start { get; private set; }
    [field:SerializeField] public Button Exit { get; private set; }
}
