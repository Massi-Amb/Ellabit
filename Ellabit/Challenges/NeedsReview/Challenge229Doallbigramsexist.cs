namespace Ellabit.Challenges
{
    public class Challenge229Doallbigramsexist : IChallenge
    {
        public string? Header { get; set; } = "Do all bigrams exist?";
        public string? Code { get; set; } = @"
using System;

namespace Ellabit;

using System;

public class Challenge
{
    public  bool CanFind(string[] bigrams, string[] words) {
			
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
        bool sumResult;
        try 
        {
            sumResult = tmp.canfind(new  string[]  {  "" at"", ""be"", ""th"", au"" }, new string[] { ""beautiful"", ""the"", ""hat"" }) ;
        } catch (Exception ex) 
        {
            return (false, ex.ToString() + "" "" + ex.Message);
        }
        return (sumResult ==  true ,  $""returned: {sumResult}  expected: true"");
    }
    public (bool pass, string message) Test2()
    {
        var tmp = new Challenge();
        bool sumResult;
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
        bool sumResult;
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
        public string? Description { get; set; } = @"You are given an input array of bigrams, and an array of words.

Write a function that returns true if every single bigram from this array can be found at least once in an the list of words.

Examples
CanFind(new string[] { ""at"", ""be"", ""th"", au"" }, new string[] { ""beautiful"", ""the"", ""hat"" }) ➞ true

CanFind(new string[] { ""ay"", ""be"", ""ta"", cu"" }, new string[] { ""maybe"", ""beta"", ""abet"", ""course"" }) ➞ false
// ""cu"" does not exist in any of the words.

CanFind(new string[] { ""th"", ""fo"", ""ma"", or"" }, new string[] { ""the"", ""many"", ""for"", ""forest"" }) ➞ true

CanFind(new string[] { ""oo"", ""mi"", ""ki"", la"" }, new string[] { ""milk"", ""chocolate"", ""cooks"" }) ➞ false
Notes
A bigram is string of two consecutive characters in the same word.
If the array of words is empty, return false.";
        public List<string> Tests { get; set; } = new string[] { "Test1", "Test2", "Test3" }.ToList();
        private Dictionary<string, string> _tags = new Dictionary<string, string>(StringComparer.OrdinalIgnoreCase);
        public Dictionary<string, string> Tags { get => _tags; set => _tags = value; }
    }
}
