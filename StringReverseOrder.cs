using System;

public class StringReverseOrder
{
	public string GetReverseWordOrder(string input)
	{
	    var strOut = new StringBuilder();
	    while(input.length > 0)
	    {
            //index of next space
	        var nextSpace = input.indexOf(" ");
            //this should get us our next word plus a trailing space
            var word = input.Substring(0, nextSpace);
            //Prepend word to string builder, with a leading space.  Two calls because concatenation tends to get slow
	        strOut.Insert(0, word);
	        strOut.Insert(0, " ");

            //trim the word off of input.  We also want to remove extra whitespace at the start or end of the string
	        input = (input.Substring(nextSpace)).Trim();
	    }
	    return strOut.ToString().Trim();
	}
}
