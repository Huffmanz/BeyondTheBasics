﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IKillable
{
    // Start is called before the first frame update
    void Kill();

    string GetName();
}
