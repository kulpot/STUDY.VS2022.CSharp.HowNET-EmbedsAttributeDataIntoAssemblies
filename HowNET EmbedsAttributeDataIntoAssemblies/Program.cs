using System;

//link ref:https://www.youtube.com/watch?v=zt20aadTEmw&list=PLRwVmtr-pp05brRDYXh-OTAIi-9kYcw3r&index=8
// .NET MSIL(Microsoft Intermediate Language) level
/*
 *          BATCH FILE  //(CMD)
 *       
 *    C:\>copy con i.bat
 *    csc MainClass.cs
 *    ildasm /out:MyMsil.txt MainClass.exe
 *    start MyMsil.txt
 *    ^Z                //(press enter)
 *              1 files(s) copied.     //(result) 
 *    C:\>i             //(press enter) mean assemble
 *                      //(result)
 */

// ASCII Table ---------------

class MeAttribute : Attribute 
{ 
    //public MeAttribute(int arg, string meString)
    public MeAttribute(int arg)
    {

    }
    public string MeString { get; set; }
}

//[Me(5 + 3, "I love programming with attributes")]
//[Me(5 + 3, "I love programming with attributes" + new Random().Next().ToString())]
[Me(5 + 3, MeString = "I love programming with attributes")]

class MainClass
{
    static void Main()
    {

    }
}