﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Global 
{

    /* 
     * The code here demonstrates a way to generate an id based on a type.
     * Note that this is not a Globally unique identififer. 
     * In other words, if you create two different attack “actions” both 
     * instances would share an identical id as generated by this code. 
     * The idea will be that when I post a notification for an action, 
     * I can refer to its types id instead of other options like comparing 
     * strings or attempts at casting to a sub-type, etc.
     */
     
    public static int GenerateID<T> () 
    {
        return GenerateID (typeof(T));
    }

    public static int GenerateID (System.Type type) 
    {
        return Animator.StringToHash (type.Name);
    }

    public static string PrepareNotification<T> () 
    {
        return PrepareNotification (typeof(T));
    }

    public static string PrepareNotification (System.Type type) 
    {
        return string.Format ("{0}.PrepareNotification", type.Name);
    }

    public static string PerformNotification<T> () 
    {
        return PerformNotification (typeof(T));
    }

    public static string PerformNotification (System.Type type) 
    {
        return string.Format ("{0}.PerformNotification", type.Name);
    }
}