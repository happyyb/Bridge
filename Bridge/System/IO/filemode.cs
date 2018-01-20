// ==++==
//
//   Copyright (c) Microsoft Corporation.  All rights reserved.
//
// ==--==
/*============================================================
**
** <OWNER>Microsoft</OWNER>
**
** Class:  File
**
**
** Purpose: A collection of methods for manipulating Files.
**
**          April 09,2000 (some design refactorization)
**
===========================================================*/
/*
 * https://github.com/Microsoft/referencesource/blob/master/mscorlib/system/io/filemode.cs
 */


using System;
using System.Text;
using System.Diagnostics.Contracts;
using Bridge;

namespace System.IO
{
    [Reflectable]
    [FileName("system/io/io.js")]
    [Convention]
    public enum FileMode
    {
        CreateNew = 1,
        Create,
        Open,
        OpenOrCreate,
        Truncate,
        Append
    }
}
