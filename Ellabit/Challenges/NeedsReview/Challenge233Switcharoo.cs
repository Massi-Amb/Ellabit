﻿namespace Ellabit.Challenges
{
    public class Challenge233Switcharoo : IChallenge
    {
        public string? Header { get; set; } = "Switcharoo";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

public class Challenge 
{
    public  string FlipEndChars(object str) 
    {
      
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
        public string? Description { get; set; } = @"Create a function that takes a string and returns a new string with its first and last characters swapped, except under three conditions:

If the length of the string is less than two, return ""Incompatible."".
If the argument is not a string, return ""Incompatible."".
If the first and last characters are the same, return ""Two's a pair."".
Examples
FlipEndChars(""Cat, dog, and mouse."") ➞ "".at, dog, and mouseC""

FlipEndChars(""ada"") ➞ ""Two's a pair.""

FlipEndChars(""Ada"") ➞ ""adA""

FlipEndChars(""z"") ➞ ""Incompatible.""

FlipEndChars([1, 2, 3]) ➞ ""Incompatible.""
Notes
Tests are case sensitive (e.g. ""A"" and ""a"" are not the same character).";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
