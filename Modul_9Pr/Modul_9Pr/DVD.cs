﻿using Modul_9Pr;

internal class DVD : Storage
{
    private string v1;
    private string v2;
    private int v3;
    private int v4;
    private object singleLayer;

    public DVD(string v1, string v2, int v3, int v4, object singleLayer)
    {
        this.v1 = v1;
        this.v2 = v2;
        this.v3 = v3;
        this.v4 = v4;
        this.singleLayer = singleLayer;
    }
}