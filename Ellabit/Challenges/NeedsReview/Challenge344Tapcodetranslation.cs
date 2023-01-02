﻿namespace Ellabit.Challenges
{
    public class Challenge344Tapcodetranslation : IChallenge
    {
        public string? Header { get; set; } = "Tap code translation";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

// Its possible to solve using some or all of these librarys.

using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Challenge
{
		public  string TapCode(string text)
		{
				return string.Empty;
		}
}

";
        public string? TestCode { get; set; } = @"
using System;

namespace Ellabit;

public class TestChallenge
{
    public (bool pass, string message) Test1()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.<rep.test1>;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == <rep.test.result1>,  $""returned: {sumResult}  expected: <rep.test.result1Val>"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.<rep.test2>;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult == <rep.test.result2>,   $""returned: {sumResult}  expected: <rep.test.result2Val>"");
    }
    public (bool pass, string message) Test3()
    {
        var tmp = new Challenge();
        string sumResult;
        try 
        {
            sumResult = tmp.<rep.test3>;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + ""\n"" + ex.Message);
        }
        return (sumResult == <rep.test.result3>,   $""returned: {sumResult}  expected: <rep.test.result3Val>"");
    }
}
";
        public string? Description { get; set; } = @"Tap code is a way to communicate messages via a series of taps (or knocks) for each letter in the message. Letters are arranged in a 5x5 polybius square, with the letter ""K"" being moved to the space with ""C"".

   1  2  3  4  5
1  A  B C\K D  E
2  F  G  H  I  J
3  L  M  N  O  P
4  Q  R  S  T  U
5  V  W  X  Y  Z
Each letter is translated by tapping out the row and column number that the letter appears in, leaving a short pause in-between. If we use ""."" for each tap, and a single space to denote the pause:

text = ""break""

""B"" = (1, 2) = "". ..""
""R"" = (4, 2) = "".... ..""
""E"" = (1, 5) = "". .....""
""A"" = (1, 1) = "". .""
""K"" = (1, 3) = "". ...""
Another space is added between the groups of taps for each letter to give the final code:

""break"" = "". .. .... .. . ..... . . . ...""
Write a function that returns the tap code if given a word, or returns the translated word (in lower case) if given the tap code. When translating from tap-code, default to the letter ""c"" if the tap-code "". ..."" is found.

Examples
tapCode(""break"") ➞ "". .. .... .. . ..... . . . ...""

tapCode("".... ... ... ..... . ..... ... ... .... ...."") ➞ ""spent""
Notes
For more information on tap code, please see the resources section. The code was widely used in WW2 as a way for prisoners to communicate.";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
