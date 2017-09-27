using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace SQLServerClrNS
{
    /*
    You can find the SQL script you need to run on SQL DB in the file "SQLScript.txt" in 
    this "SQLServerCLR" project
    */

    public class CLRFunctions
    {
        public static string HelloWorld(string name)
        {
            return "Hello " + name;
        }

        public static string ReplaceWithRegExp(string SourceStr, string RegExp, string ReplacementStr)
        {
            return Regex.Replace(SourceStr, RegExp, ReplacementStr);
        }
    }
}